using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCSC;
using PCSC.Exceptions;
using PCSC.Utils;
using System.Threading;

namespace Lab2_czytnik_kaart_chipowych
{
    public partial class Form1 : Form
    {
        private static SCardError error;
        private static SCardReader reader;
        private static System.IntPtr intptr;
        private static SCardContext context;
        int value = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            context = new SCardContext(); //nawiązanie połączenia z czytnikiem

            string[] readerList = context.GetReaders(); // wczytanie dostępnych czytników do listy
            Boolean noReaders = readerList.Length <= 0;
            if (noReaders)
            {
                throw new PCSCException(SCardError.NoReadersAvailable, "Czytnik nie zostal odnaleziony");
            }

            int counter = 1;
            richTextBoxOutput.AppendText("Wybierz czytnik: \n");
            foreach (string element in readerList)
            {
                Console.WriteLine(" - F" + counter + " -> " + element);
                counter++;
            }
            var input = Console.ReadKey();
            string tmp = readerList[0];
            switch (input.Key)
            {

                case ConsoleKey.F1:
                    tmp = readerList[0];
                    break;

                case ConsoleKey.F2:
                    tmp = readerList[1];
                    break;
            }

            Console.WriteLine("Wcisnij dowolny klawisz by kontynowac...");
            Console.ReadKey();

            //w zależności od wybranego czytniku wybrany zostanie odpowiedni protokół T0 lub T1. W przypadku pozostałych zostanie wyrzucony wyjątek 
            reader = new SCardReader(context);
            error = reader.Connect(tmp, SCardShareMode.Shared, SCardProtocol.T0 | SCardProtocol.T1);
            if (error != SCardError.Success)
            {
                throw new PCSCException(error, SCardHelper.StringifyError(error));
            }

            if (reader.ActiveProtocol == SCardProtocol.T0)
            {
                intptr = SCardPCI.T0;

            }
            else if (reader.ActiveProtocol == SCardProtocol.T1)
            {
                intptr = SCardPCI.T1;
            }
            else
            {
                Console.WriteLine("Protokol nie jest obslugiwany");
                Console.WriteLine("Wcisnij dowolny klawisz by kontynowac...");
                Console.ReadKey();
            }
        }
    }
}
