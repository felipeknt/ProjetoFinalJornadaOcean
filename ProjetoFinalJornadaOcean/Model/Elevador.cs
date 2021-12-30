using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalJornadaOcean.Model
{
    internal class Elevador
    {
        private int andares, capacidade;
        private int andarAtual = 0;
        private int qtdPessoas = 0;
        //O usuário vai informar quantos andares o elevador possui e a capacidade de pessoas.
        public void Inicializar(int qtdAndares, int qtdMaxPessoas) {
            //deve receber como parâmetros a capacidade do elevador e o total de
            //andares no prédio(os elevadores sempre começam no térreo e vazio);
            andares = qtdAndares;
            capacidade = qtdMaxPessoas;

            Console.WriteLine($"Quantidade de andares: {andares}\nCapacidade máxima de pessoas: {capacidade}");
        }

        public void Entrar() {
            //deve acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);

            //verifica se tem espaço no elevador
            if (capacidade <= qtdPessoas) { 
                qtdPessoas++;
            }else{
                Console.WriteLine("Elevador cheio.");
            }
        }

        public void Sair() {
            //deve remover uma pessoa do elevador(só deve remover se houver alguém dentro dele);
            if (qtdPessoas == 0) {
                Console.WriteLine("O elevador encontra-se vazio.");
            }else{
                qtdPessoas--;
            }
        }

        public void Subir() {
            //deve subir um andar ( nao deve subir se ja estiver no ultimo andar)
            if (andares == andarAtual) {
                Console.WriteLine("O elevador já está no ultimo andar e não pode mais subir.");
            }else {

                Console.WriteLine($"Elevador está saindo do {andarAtual} e subindo para o: {andarAtual++}");
                andarAtual++;
            }
        }

        public void Descer() {
            //Deve descer um andar (não deve descer se já estiver no térreo.)
            if (andarAtual == 0) {
                Console.WriteLine($"Elevador está saindo do {andarAtual} e indo para o: {andarAtual--}");
                andarAtual--; 
            }
        }
    }
}
