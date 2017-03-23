using System;
using System.Threading;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace Server
{

    class Program
    {

        static void Main(string[] args)
        {
            //búið er til breytuna local sem heldur localhost ip
            IPAddress local = IPAddress.Parse( "127.0.0.1" );
            //búið er til TcpListener-inn serverSocket sem tengjist localhostinu með portinu 8888
            TcpListener serverSocket = new TcpListener(local, 8888);
            //búið er til clientSocket
            TcpClient clientSocket = default(TcpClient);
            //teljari
            int teljari;


            //byrjar serverSocket
            serverSocket.Start();
            //Lætur vita að serverinn sé kominn upp
            Console.WriteLine(" >> " + "Server keyrður");


            //Núllstillt teljarann
            teljari = 0;
            //endalaust keyrt
            while (true)
            {
                teljari += 1;
                //Tekið við tengingu
                clientSocket = serverSocket.AcceptTcpClient();
                //skrifar út númer hvað þessi client er
                Console.WriteLine(" >> " + "Client numer:" + Convert.ToString(teljari) + " keyrður!");
                //kallar í mathClient 
                mathClient client = new mathClient();
                //byrjar byrjaClient 
                client.byrjaClient(clientSocket, Convert.ToString(teljari));
                
            }


            //Lokað á eftir sér
            /*clientSocket.Close();

            serverSocket.Stop();

            Console.WriteLine(" >> " + "exit");

            Console.ReadLine();*/

        }

    }


    
    //Þessi klasi sér um alla Clientana
    public class mathClient
    {
        
        TcpClient clientSocket;
        double t1; //tala1
        double t2; //tala2
        Random rand = new Random();//gert fyrir randomtölur
        double svar; //heldur utan um svarið
        string daemi; //heldur utan um dæmið sjálft, t.d. t1+t2=svar
        string[] names = new string[] { "John", "Bill", "George", "Bob", "Stephen", "Paul", "Fred", "Jacob", "Harry", "Michael", "Donald", "Peter", "William", "Dennis",  };//nöfn fyrir orðadæmin
        string[] food = new string[] { "apples", "cookies", "bananas", "oranges" };//matur fyrir orðadæmi
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();//stafrófið fyrir sinnum dæmin
        string clientNumer; //númerið á clientnum
        string[] s = new string[2];//það sem kemur frá clientnum
        int erfidarstig = 0; //erfidarstig sér um erfiðleikann
        //faPlus sér um að búa til plús dæmi
        public void faPlus()
        {
            //ef erfiðarstigið er 1 er það einfalt plús dæmi
            if (erfidarstig == 1)
            {
                t1 = rand.Next(1, 10);
                t2 = rand.Next(1, 10);
                svar = t1 + t2;
                daemi = names[rand.Next(0, names.Length)] + " has " + t1 + " "+ food[rand.Next(0, food.Length)] + ", and then he found " + t2 + " more. How many does he have? = " + svar;
            }
            //hér þarf notandinn að bæta við 20% við t1
            if (erfidarstig == 2)
            {
                t1 = rand.Next(8000, 20000);
                t2 = Math.Round((t1 * 0.2), 0);
                svar = t1 + t2;
                daemi = names[rand.Next(0, names.Length)] + " got " + t1 + " points in a video game. Then he got 20% additional bonus points. How much points does he have? = " + svar;

            }
            //hér þarf notandinn að bæta við random prósentatölu
            if (erfidarstig == 3)
            {
                t1 = rand.Next(100000, 500000);
                t2 = rand.Next(1, 20);
                svar = Math.Round((t1 * (1 + (t2 / 100))), 0);
                daemi = names[rand.Next(0, names.Length)] + "'s monthly wage is " + t1 + " kr. Today he got a " + t2 + "% raise. How much is his wage now? = " + svar;
            }
        }

        Double Factorial(double n)//reiknar út hrópmerkt á tölunni sem er sent inn
        {
            double result = 1;

            for (double i = 2; i <= n; ++i)
                result *= i;

            return result;
        }

        //faMinus sér um að búa til mínus dæmi
        public void faMinus()
        {
            if (erfidarstig == 1)//einfalt mínus dæmi
            {
                t1 = rand.Next(10, 20);
                t2 = rand.Next(1, 10);
                svar = t1 - t2;
                daemi = names[rand.Next(0,names.Length)]+" went to the shop and bought " + t1 + " " + food[rand.Next(0,food.Length)] +" but ate " + t2 + " of them on his way home. How many does he have left? = " + svar;
            }
            if (erfidarstig == 2)//hér þarf notandinn að draga frá t1 24,5%
            {
                t1 = rand.Next(500000, 2000000);
                t2 = Math.Round((t1 * 0.245),0);
                svar = t1 - t2;
                daemi = names[rand.Next(0, names.Length)] + " won " + t1 + " kr. in the lottery but had to pay 24,5% of the winnings to taxes. How much money did he get? = " + svar;
            }
            if (erfidarstig == 3)//hér þarf notandinn að draga frá t1 einhverji random prósentutölu
            {
                t1 = rand.Next(10000, 30000);
                t2 = rand.Next(1000, 10000);
                svar = t1 - t2;
                daemi = names[rand.Next(0, names.Length)] + " bought computer parts for " + t1 + " kr. and got a " + Math.Round(((t2 / t1) * 100), 2) + "% discount. How much did he pay? = " + svar;
            }

        }
        //faSinnum sér um að búa til margföldunardæmi
        public void faSinnum()
        {
            if (erfidarstig == 1)//einfalt margföldunardæmi
            {
                t1 = rand.Next(1, 10);
                t2 = rand.Next(5, 10);
                svar = t1 * t2;
                string matur = food[rand.Next(0,food.Length)];
                daemi = names[rand.Next(0, names.Length)] + " bought " + t1 + " boxes of " + matur + ". Each box has " + t2 + " pieces of " + matur + ". How many " + matur + " did he buy? = " + svar;
            }
            if (erfidarstig == 2)//hrópmerkt margföldunardæmi
            {
                t1 = rand.Next(2, 8);
                svar = Factorial(t1);
                string stafir = "";
                for (int i = 0; i < t1; i++)
                {
                    stafir += alphabet[rand.Next(0, alphabet.Length)] +",";
                }
                stafir = stafir.Remove(stafir.Length - 1, 1);
                daemi = "In how many ways can you arrange the letters " + stafir + " ? = " + svar;
                // Svarið er: Hversu margir stafir + hrópmerkt
            }
            if (erfidarstig == 3)//líkindar margföldunar dæmi, formúla = P(n,k) = n!/(n-k)!
            {
                t1 = rand.Next(2, 5);
                t2 = rand.Next(5, 10);
                svar = (Factorial(t2) / Factorial(t2 - t1));
                string stafir = "";
                for (int i = 0; i < t2; i++)
                {
                    stafir += alphabet[rand.Next(0, alphabet.Length)] + ",";
                }
                stafir = stafir.Remove(stafir.Length - 1, 1);
                daemi = "In how many ways can you arrange the letters " + stafir + " into " + t1 + " slots? = " + svar;
            }
        }

        public void byrjaClient(TcpClient inClientSocket, string clientNr)
        {

            this.clientSocket = inClientSocket;
            this.clientNumer = clientNr;//númer hvaða client er verið að vinna með
            Thread ctThread = new Thread(doMath);//búið er til nýjan thread doMath
            ctThread.Start();//thread-ið byrjað

        }
        //doMath er keyrt á mörgum thread-um eftir að byrjaClient hefur verið keyrt
        private void doMath() 
        {
           
            int requestCount = 0    ; //hversu oft sent hefur verið dæmi
            byte[] bytesFrom = new byte[10025]; //búið til þess að taka við gögnum
            string dataFromClient = null;//þessi strengur tekur við það sem kemur frá clientnum
            string mathtype=null;//hverskonar dæmi notandinn valdi. plús, mínus eða margföldun
            Byte[] sendBytes = null;//sendir bytes
            string serverResponse = null;//svar serversins
            string rCount = null;
            int points = 0;//stiginn sem notandinn nær
            //núll stillir hana
            //requestCount = 0;
            
            while ((true))//gerist endalaust
            {

                try
                {
                    
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream(); //nær í streamið
                    networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);//fær skilaboð frá client
                    dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);//heldur utan um skilaboð frá client
                    s = dataFromClient.Split('$');//splittar skilaboðunum í array hjá $ merkinu
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));//tekur skilaboðin frá client að $ merkinu
                    if (s[0] == "plus" || mathtype == "plus")//ef notandinn valdi plús dæmi
                    {
                        mathtype = "plus";
                        //ef ekkert erfiðarstig var valið
                        if (erfidarstig==0)
                        {
                            erfidarstig=Convert.ToInt32(s[1]);//þá er sett erfiðarstig sem s[1]
                        }
                        faPlus();//fær plús dæmi
                        
                    }
                    else if (s[0] == "minus" || mathtype == "minus")//ef notandinn valdi mínus dæmi
                    {
                        mathtype = "minus";
                        if (erfidarstig == 0)
                        {
                            erfidarstig = Convert.ToInt32(s[1]);
                        }
                        faMinus();
                        
                    }
                    else if (s[0] == "multi" || mathtype == "multi")//ef notandinn valdi margföldunardæmi dæmi
                    {
                        mathtype = "multi";
                        if (erfidarstig == 0)
                        {
                            erfidarstig = Convert.ToInt32(s[1]);
                        }
                        faSinnum();
                        
                    }
                    if (dataFromClient == "right")//ef svarað er rétt fær notandinn 1 stig
                    {
                        points++;
                    }
                    else if (dataFromClient == "wrong")//ef ekki missir hann stig
                    {
                        points--;
                    }
                    
                    
                    rCount = Convert.ToString(requestCount);
                    serverResponse = "Server til client(" + clientNumer + ") " + " daemi nr. " +rCount;//það sem er sent í server gluggann
                    daemi = daemi + "=" + points; //bætir stigum við
                    sendBytes = Encoding.ASCII.GetBytes(daemi);//breytir dæmi í bytes
                    networkStream.Write(sendBytes, 0, sendBytes.Length);//sendir dæmið yfir
                    
                    networkStream.Flush();

                    Console.WriteLine(" >> " + serverResponse);

                }

                catch (Exception ex)
                {
                    return;

                }
               

            }

        }

    }

}

