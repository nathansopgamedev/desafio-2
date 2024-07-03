using UnityEngine;

public class calculadoraDePartidasRankeadas : MonoBehaviour {
    
    public float vitorias;
    public float derrotas;
    public float resultado;

    private void Start() {
        CalcularSaldoEExibirMensagem(45, 24);
    }

    void CalcularSaldoEExibirMensagem(float vitorias, float derrotas){

        resultado = vitorias - derrotas;

        if(resultado < 10){
            print("O Herói tem um saldo de " + resultado + "vitórias e está no nível Ferro");
        } else if (resultado >= 11 && resultado <= 20){
            print("O Herói tem um saldo de " + resultado + "vitórias e está no nível Bronze");
        } else if (resultado >= 21 && resultado <= 50){
            print("O Herói tem um saldo de " + resultado + "vitórias e está no nível Prata");
        } else if (resultado >= 51 && resultado <= 80){
            print("O Herói tem um saldo de " + resultado + "vitórias e está no nível Ouro");
        } else if (resultado >= 81 && resultado <= 90){
            print("O Herói tem um saldo de " + resultado + "vitórias e está no nível Diamante");
        } else if (resultado >= 91 && resultado <= 100){
            print("O Herói tem um saldo de " + resultado + "vitórias e está no nível Lendário");
        } else if(resultado >= 101) {
            print("O Herói tem um saldo de " + resultado + "vitórias e está no nível Imortal");
        }
    }
}