using System;
using System.IO;

namespace SimuladorCaixaEletronico
{
    public class Conta
    {
        private int _id;
        private string _name;
        private int _senha;

        private float _saldo;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public float Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public void SaveToFile(string filePath)
        {
            File.WriteAllLines(filePath, new string[] { _id.ToString(), _name, _senha.ToString() });
        }

        public static Conta LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            string[] lines = File.ReadAllLines(filePath);
            return new Conta
            {
                Id = int.Parse(lines[0]),
                Name = lines[1],
                Senha = int.Parse(lines[2])
            };
        }
    }
}
