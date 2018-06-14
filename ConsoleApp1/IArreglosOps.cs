namespace ConsoleApp1
{
    public interface IArreglosOps
    {
        void LeerArreglo(int[,] x);
        int[,] MultiplicarArreglo(int[,] x, int[,] y, int[,] n);
        int[,] RellenarArreglo(int[,] x);
    }
}