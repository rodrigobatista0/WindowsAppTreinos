using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinosJC
{
    public class TreinoJC
    {
        private double distancia;
        private int duracao;
        private string tipoTreino;

        //Getters / Setters

        public double p_Distancia
        {
            get { return distancia; }
            set
            {
                if (value > 0)
                {
                    distancia = value;
                }
            }
        }

        public int p_Duracao
        {
            get { return duracao; }
            set
            {
                if (value > 0)
                {
                    duracao = value;
                }
            }

        }

        public string p_TipoTreino
        {
            get { return tipoTreino; }
            set
            {
                string dados = value.ToLower().Trim();
                if (dados == "corrida" || dados == "caminhada" || dados == "misto")
                {
                    tipoTreino = char.ToUpper(dados[0]) + dados.Substring(1);
                }
                else
                {
                    tipoTreino = "Misto";
                }
            }
        }

        public double VelocidadeMedia()
        {
            return (distancia * 1000.0) / duracao;
        }

        public void CompararDuracao(int valor, out double dist, out double vel)
        {
            if (duracao > valor)
            {
                dist = distancia;
                vel = VelocidadeMedia();
            }
            else
            {
                dist = -1;
                vel = -1;
            }
        }
        public  double CompararDuracao(string tipo)
        {
            if(tipoTreino.ToLower().Trim() == tipo.ToLower().Trim())
            {
                return VelocidadeMedia();
            }
            else
            {
                return -1.0;
            }
        }

        public TreinoJC()
        {
            distancia = 10.0;
            duracao = 3600;
            tipoTreino = "Misto";
        }

        public TreinoJC(double di, int dura, string tipotr)
        {
            p_Distancia = di;
            p_Duracao = dura;
            p_TipoTreino = tipotr;

            if(p_Distancia == 0)
            {   
                p_Distancia = 10.0;
            }

            if(p_Duracao == 0)
            {
                p_Duracao = 3600;
            }
            
            if(p_TipoTreino == null)
            {
                p_TipoTreino = "Misto";
            } 

        }

        public override string ToString()
        {
            double horas = duracao / 3600.0;
            return $"{tipoTreino}: {duracao} ({horas})";
        }

        public int CompararVelocidade(TreinoJC outroTreino)
        {
            double limite = 1000.0 / 300.0;

            if(this.VelocidadeMedia() < limite || outroTreino.VelocidadeMedia() < limite)
            {
                return 0;
            }

            if(this.VelocidadeMedia() < outroTreino.VelocidadeMedia() )
            {  
                return 1;
            }

            return -1;
        }   

    }
}
