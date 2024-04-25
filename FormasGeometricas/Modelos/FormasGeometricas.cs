namespace FormasGeometricas.Modelos;

internal class FormaGeometrica
{

    public double CalcularArea(Quadrado q)
    {
        return q.BQuadrado*q.AQuadrado;
    }

    public double CalcularArea(Circulo c)
    {
        return Math.PI*Math.Pow(c.Raio,2);
    }

    public double CalcularArea(Triangulo t)
    {
        return (t.Btriangulo*t.ATriangulo)/2;
    }
}