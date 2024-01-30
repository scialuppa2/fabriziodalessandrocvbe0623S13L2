namespace esercizioS13L2
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Inserisci il nome: ");
            string nome = Console.ReadLine();

            Console.Write("Inserisci il cognome: ");
            string cognome = Console.ReadLine();

            Console.Write("Inserisci l'età: ");
            if (int.TryParse(Console.ReadLine(), out int eta))
            {
                Persona persona = new Persona(nome, cognome, eta);

                Console.WriteLine(persona.GetDettagli());
            }
            else
            {
                Console.WriteLine("Inserimento dell'età non valido.");
            }
        }
    }

    class Persona
    {
        private string nome;
        private string cognome;
        private int eta;

        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 2 && char.IsUpper(value[0]))
                {
                    nome = value;
                }
                else
                {
                    Console.WriteLine("Il nome non è valido.");
                }
            }
        }

        public string Cognome
        {
            get
            {
                return cognome;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 2 && char.IsUpper(value[0]))
                {
                    cognome = value;
                }
                else
                {
                    Console.WriteLine("Il cognome non è valido.");
                }
            }
        }

        public int Eta
        {
            get
            {
                return eta;
            }
            set
            {
                if (value >= 0)
                {
                    eta = value;
                }
                else
                {
                    Console.WriteLine("L'età non può essere negativa.");
                }
            }
        }

        public string GetDettagli()
        {
            return $"Nome: {Nome}, Cognome: {Cognome}, Età: {Eta}";
        }

    }












}

