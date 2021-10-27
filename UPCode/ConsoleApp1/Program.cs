using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCSC;
using PCSC.Utils;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        private static SCardError error;
        private static SCardReader reader;
        private static System.IntPtr intptr;
        private static SCardContext context;
        static byte[] command;
        static void Main(string[] args)
        {
            context = new SCardContext();
            context.Establish(SCardScope.System);
            var readerList = context.GetReaders();

            if (readerList.Length <= 0)
            {
                Console.Write("No readers found, aborting \n");
                return;
            }

            reader = new SCardReader(context);
            error = reader.Connect(readerList[0], SCardShareMode.Shared, SCardProtocol.T0 | SCardProtocol.T1);
            if (error != SCardError.Success)
            {
                Console.Write("SCardError: " + error + "\n");
                return;
            }

            if (reader.ActiveProtocol == SCardProtocol.T0)
            {
                intptr = SCardPCI.T0;
                Console.Write("Current protocol is: T0 \n");
            }
            else if (reader.ActiveProtocol == SCardProtocol.T1)
            {
                intptr = SCardPCI.T1;
                Console.Write("Current protocol is: T1 \n");
            }
            else
                Console.Write("This protocol is not implemented");

            XD();

            while (true) ;
        }

        static void XD()
        {
            //select telecom
            command = new byte[] { 0xA0, 0xA4, 0x00, 0x00, 0x02, 0x7F, 0x10 };
            sendCommand("SELECT TELECOM");

            //get response
            command = new byte[] { 0xA0, 0xC0, 0x00, 0x00, 0x16 };
            sendCommand("GET RESPONSE");

            //select sms
            command = new byte[] { 0xA0, 0xA4, 0x00, 0x00, 0x02, 0x6F, 0x3C };
            sendCommand("SELECT SMS");

            //get response
            command = new byte[] { 0xA0, 0xC0, 0x00, 0x00, 0x16 };
            sendCommand("GET RESPONSE");

            //read record
            command = new byte[] { 0xA0, 0xB2, 0x01, 0x04, 0xB0 };
            sendCommand("READ RECORD");


            //get response
            command = new byte[] { 0xA0, 0xC0, 0x00, 0x00, 0x16 };
            sendCommand("GET RESPONSE");
            Console.WriteLine("XDDDD");
        }

        static void sendCommand(String action)
        {
            SCardPCI receuvePci = new SCardPCI();
            byte[] received = new byte[256];

            error = reader.Transmit(intptr, command, receuvePci, ref received);
            if (error != SCardError.Success)
            {
                Console.Write("Send command " + action + " failed: " + error + "\n");
            }
            writeResponse(received, action);
            /*else
            {
                string s = System.Text.Encoding.UTF8.GetString(received, 0, received.Length);
                richTextBoxOutput.AppendText("Response: " + s);
                richTextBoxOutput.AppendText("\n");
                richTextBoxOutput.AppendText(received.Length + "\n");
                for (int q=0; q<received.Length; ++q)
                    richTextBoxOutput.AppendText(received[q] + "  ");

                richTextBoxOutput.AppendText("\n");
            }*/
        }
        static void writeResponse(byte[] received, String responseCode)
        {
            Console.Write(responseCode + ": ");
            Console.WriteLine(Encoding.ASCII.GetString(received));
            Console.Write("{0:X2}", received[0]);
            Console.WriteLine();
            for (int i = 1; i < received.Length ; i++)
            {
                 Console.Write("{0:X2}", received[i]);
                // Console.Write(received[i]);
                if (i % 7 == 0) Console.WriteLine();

            }
            Console.WriteLine();
        }
    }
}
