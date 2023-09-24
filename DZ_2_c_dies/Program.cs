using System.Security.Cryptography.X509Certificates;

namespace DZ_2_c_dies
{
    internal class Program

    {
        class Website
        {
            string _nome;
            string _url;
            string _ob;
            string _ip;
            public string nome
            {
                get { return _nome; }
                set { _nome = value; }
            }
            public string url
            {
                get { return _url; }
                set { _url = value; }
            }
            public string ob
            {
                get { return _ob; }
                set { _ob = value; }
            }
            public string ip
            {
                get { return _ip; }
                set { _ip = value; }
            }
            public Website()
            {
                _nome = "niente";
                _url = "niente";
                _ob = "niente";
                _ip = "niente";
            }
            public Website(string nome, string url, string ob, string ip)
            {
                this._nome = nome;
                this._url = url;
                this._ob = ob;
                this._ip = ip;
            }

            public void Mostra()
            {
                Console.WriteLine("\n Имя сайта : " + _nome + "\n адрес сайта : " + _url + "\n описание сайта : " + _ob + "\n ip сайта : " + _ip);
            }
        }

        static void Main(string[] args)
        {
            // задание 1
            Console.WriteLine("Введите ширину квадрата : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите символ : ");
            char ch=Convert.ToChar(Console.ReadLine());
            for(int i = 0; i < n; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }

            // задание 2
            Console.WriteLine("Введите число : ");
            string? cislo = Console.ReadLine();
            bool proverka(string str)
            {
                for(int i = 0; i < str.Length / 2; ++i)
                {
                    if (str[i] != str[str.Length - 1 - i]) { return false; }
                }
                return true;
            }
            Console.WriteLine("Проверка на палиндром " + proverka(cislo));

            // задание 3
            Website site = new Website();
            site.Mostra();
            site.nome = "aaaaaaa";
            site.url = "bbbbbbb";
            site.ob = "ccccccc";
            site.ip = "ddddddd";
            site.Mostra();
        }
    }
}