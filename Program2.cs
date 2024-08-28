using System;
public interface Imensaje
{
    string getMensaje();
}

public class mensajebase : Imensaje
{
    public string getMensaje()
    {
        return "Este es el mensaje de prueba";
    }
}
public abstract class mensajeDecorador : Imensaje
{
    protected Imensaje mensajedeco;

    public abstract string getMensaje();
    public mensajeDecorador(Imensaje mensaje)
    {
        this.mensajedeco = mensaje;
    }
}

public class EncriptarMensaje : mensajeDecorador
{
    public EncriptarMensaje(Imensaje mensaje) : base(mensaje) { }
    public override string getMensaje()
    {
        return mensajedeco.getMensaje() + " ENCRIPTADO";
    }
}
public class ComprimirMensaje : mensajeDecorador
{
    public ComprimirMensaje(Imensaje mensaje) : base(mensaje) { }
    public override string getMensaje()
    {
        return mensajedeco.getMensaje() + " COMPRIMIDO";
    }
}
public class FirmarMensaje : mensajeDecorador
{
    public FirmarMensaje(Imensaje mensaje) : base(mensaje) { }
    public override string getMensaje()
    {
        return mensajedeco.getMensaje() + " FIRMADO";
    }
}
public class Program2
{
    public static void Main(string[] agrs)
    {
        Imensaje mimensaje = new mensajebase();
        Imensaje mimensaje1 = new mensajebase();
        Imensaje mimensaje2 = new mensajebase();
        Console.WriteLine(mimensaje.getMensaje());

        mimensaje = new EncriptarMensaje(mimensaje);
        Console.WriteLine(mimensaje.getMensaje());

        mimensaje1 = new ComprimirMensaje(mimensaje1);
        Console.WriteLine(mimensaje1.getMensaje() );

        mimensaje2 = new FirmarMensaje(mimensaje2);
        Console.WriteLine(mimensaje2.getMensaje());
    }
}