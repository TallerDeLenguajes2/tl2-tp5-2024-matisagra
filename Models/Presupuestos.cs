
public class Presupuesto
{
    private int idPresupuesto;
    private string nombreDestinatario;
    private DateTime fechaCreacion;
    private List<Detalles> detalle;

    public int IdPresupuesto { get => idPresupuesto; set => idPresupuesto = value; }
    public string NombreDestinatario { get => nombreDestinatario; set => nombreDestinatario = value; }

    public List<Detalles> Detalle { get => detalle; set => detalle = value; }
    public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }

      public Presupuesto(int idPresupuesto, string nombreDestinatario, DateTime fecha)
    {
        this.idPresupuesto = idPresupuesto;
        this.nombreDestinatario = nombreDestinatario;
        fechaCreacion = fecha;
        detalle = new List<Detalles>();
    }

    public int montoPresupuesto(){
        return 0;
    }

    public int montoPresupuestoConIva(){
        return 0;
    }

    public int cantidadProductos(){
        return 0;
    }

}
