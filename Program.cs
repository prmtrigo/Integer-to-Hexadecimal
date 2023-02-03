namespace Integer_to_Hexadecimal;
class Program
{
    static string ConversaoHexadecimal(int numeroDecimal){
        
        //agora, vamos converter o número decimal
        string numeroHexadecimal = "";

        while(numeroDecimal > 0){

            //a conversão de números se dá pela divisão sucessiva e pelos restos!
            int resto = numeroDecimal % 16;

            if(resto < 10){
                //quando o resto é menor que 10, vamos somar ele à string
                numeroHexadecimal = resto + numeroHexadecimal;
            }
            else{
                //maior ou igual a 10, colocamos um caracter!
                // de A até F, representando 10 até 15
                //10,11,12,13,14,15 -> A,B,C,D,E,F

                numeroHexadecimal = (char)('A' + resto - 10) + numeroHexadecimal;
            }

            //agora, divida o número decimal por 16
            numeroDecimal = numeroDecimal/16;
        }

        //agora, devolva e mostre esse número!
        Console.WriteLine(numeroHexadecimal);
        return numeroHexadecimal;
    }

    static void Main(string[] args)
    {
        //inserindo um número decimal
        Console.WriteLine("coloque um número decimal: ");
        int numeroDecimal = Convert.ToInt32(Console.ReadLine());
        
        //chame a função
        ConversaoHexadecimal(numeroDecimal);
    }
}
