public interface IEdificio
{
void Generar();
}
public class Castillo : IEdificio
{
    public void Generar() { Console.WriteLine("Holas"); }
}

public class Torre : IEdificio
{
    public void Generar(){ Console.WriteLine("Holas"); }
}

public class Muralla : IEdificio
{
    public void Generar() { Console.WriteLine("Holas"); }
}


public interface IfabricaAbstracta
{
     IEdificio CrearEdificio();
}

public class FabricaCastillo : IfabricaAbstracta
{
    public IEdificio CrearEdificio()
    {
        return new Castillo();
    }
}

public class FabricaTorre : IfabricaAbstracta
{
    public IEdificio CrearEdificio()
    {
        return new Torre();
    }
}

public class FabricaMuralla : IfabricaAbstracta
{
    public IEdificio CrearEdificio()
    {
        return new Muralla();
    }
}
public class Program
{   public static void Main(string[] args)
    {
        IfabricaAbstracta castillo1 = new FabricaCastillo();
        IfabricaAbstracta muralla1 = new FabricaMuralla();
        IfabricaAbstracta torre1 = new FabricaTorre();

        IEdificio castillo = castillo1.CrearEdificio();
        castillo.Generar();

        IEdificio torre = torre1.CrearEdificio();
        torre.Generar();

        IEdificio muralla = muralla1.CrearEdificio();
        muralla.Generar();
    }

}

