using System;
/// <summary>
/// Proporciona las propiedades y métodos necesarios para hacer cafés,
/// calcular cantidad de agua necesaria para los cafés que se deben hacer y
/// reponer en caso de quedarse sin algún elemento
/// </summary>
//namespace EDexamenT6a8

class Cafetera
{
    /// <summary>
    /// <para>He cambiado el nombre de la clase ya que no seguía las características PasCal</para>
    /// <para>He encapsulado todas las propiedades ya que en POO no deben de existir propiedades públicas</para>
    /// </summary>
    /// <param name="marcaCafetera">Indica la marca del objeto</param>
    /// <param name="modeloCafetera">Indica el modelo del objeto</param>
    /// <param name="cantidadAgua">Indica la cantidad de agua que tiene la cafetera en el tanque</param>
    /// <param name="totalDeCapsulas">Indica el número total de cápsulas que tiene la cafetera</param>
    private string marcaCafetera;
    private string modeloCafetera;
    private double cantidaAgua;
    private double totalDeCapsulas;

    public string MarcaCafetera { get => marcaCafetera; set => marcaCafetera = value; }
    public string ModeloCafetera { get => modeloCafetera; set => modeloCafetera = value; }
    public double CantidaAgua { get => cantidaAgua; set => cantidaAgua = value; }
    public double TotalDeCapsulas { get => totalDeCapsulas; set => totalDeCapsulas = value; }


    ///<summary>
    ///He tabulado y renombrado las variables del constructor cafetera, lo que me ha permitido eliminar los comentarios
    ///</summary>
    public cafetera(string marca, string referencia, double agua, double totaldecapsulas)
    {
        this.MarcaCafetera = marca;
        this.ModeloCafetera = referencia; 
        this.TotalDeCapsulas = totaldecapsulas;
        this.CantidaAgua = agua; 
    }

    ///<summary>
        ///<para>Método que se encarga de comprobar si el café se puede preparar comprobando la cantidad de agua</para>
        ///<para>He renombrado la constante para que sea más descriptiva</para>
        ///<para>He cambiado el nombre del método ya que podía crear confusión</para>
        ///<para>He tabulado y saltado líneas dentro de la condicional ya que no seguía las normas de estilo c#</para>
        ///<para>He cambiado el número mágico por la constante para dotar de información a la condición if</para>
    ///</summary>
    ///<returns>Una cadena de texto indicando si queda agau suficiente para la realización de un café</returns>
    public string ComprobarRealizacionCafe(double numerodecafe) 
    {
        double ConsumoDeAguaPorCafe = 0.1;
        this.CantidaAgua -= numerodecafe * ConsumoDeAguaPorCafe; 
        if (this.CantidaAgua < ConsumoDeAguaPorCafe)
        {   
            this.CantidaAgua = 0;
            return "Falta agua en el depósito, por favor, revisar los niveles.";
        }
        else
        { 
            return "Quedan" + this.CantidaAgua + " centilitros";
        }
    }

    /// <summary>
        ///<para>Método que se encarga de preparar un café</para> 
        ///<para>He saltado las lines necesarias para que el código siguiese las normas generales de estilo c#</para>
    /// </summary>
    ///<returns>Una cadena de texto indicando si se ha podido realizar el café</returns>
    public string ConsumoCapsulas(double numerodecafe)
    {
        this.TotalDeCapsulas -=- numerodecafe;
        if (this.TotalDeCapsulas < 0)
        {
            this.TotalDeCapsulas = 0;
            return "Faltan cápsulas en el depósito, por favor, compre cápsulas.";
        }
        else 
        {
            return "Quedan" + this.TotalDeCapsulas + "unidades";
        }
    }

    /// <summary>
    /// Método que se encarga de reponer el número de cápsulas necesarias
    /// </summary>
    public double ReponerCapsulas(double cantidadcapsulas)
    {
        this.TotalDeCapsulas += cantidadcapsulas;
        return this.TotalDeCapsulas;
    }

    /// <summary>
    /// Método que se encarga de rellenar el depósito de agua de la cafetera
    /// </summary>
    public double LlenarDeposito(double litros)
    {
        this.CantidaAgua += litros;
        return this.CantidaAgua;
    }

    /// <summary>  
    ///<para>Método que se encarga de recuperar la información de la cafetera</para>
    /// </summary>
    public void VerEspecificacion(string modeloCafetera, string marcaCafetera)
    {
        this.MarcaCafetera = marcaCafetera;
        this.ModeloCafetera = modeloCafetera;
    }
}