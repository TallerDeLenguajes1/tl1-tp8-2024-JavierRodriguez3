// See https://aka.ms/new-console-template for more information
using Distribuidora;

var listaPendientes = new List<Tareas>();
var listaRealizadas = new List<Tareas>();

Tareas TareaA = new Tareas(1, "Primera Tarea",  20);
Tareas TareaB = new Tareas(2, "Segunda Tarea", 15);
Tareas TareaC = new Tareas(3, "Tercera Tarea", 30);
listaPendientes.Add(TareaA);
listaPendientes.Add(TareaB);
listaPendientes.Add(TareaC);

int num;
int idTarea;
string descri;
do{
    Console.WriteLine("Ingresar 1 para pasar tarea pendiente a realizada");
    Console.WriteLine("Ingresar 2 si desea buscar una tarea pendiente");
    Console.WriteLine("Ingresar 3 para salir");
    num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 1:
            Console.WriteLine("Ingresar el ID de la tarea a cambiar");
            idTarea = Convert.ToInt32(Console.ReadLine());
            foreach (Tareas Tarea in listaPendientes)
            {
                if(Tarea.Id == idTarea){
                    listaRealizadas.Add(Tarea);
                    leerLista(listaRealizadas);
                    listaPendientes.RemoveAt(idTarea - 1);
                    leerLista(listaPendientes);
                }
            }
            break;
        case 2:
            Console.WriteLine("Ingresar la descripcion a buscar");
            descri = Console.ReadLine();
            foreach (Tareas tarea in listaPendientes)
            {
                if(tarea.Descripcion == descri){
                    Console.WriteLine(tarea.Id);
                    Console.WriteLine(tarea.Descripcion);
                    Console.WriteLine(tarea.Duracion);
                }
            }
            break;
    }
}while(num != 3);

static void leerLista(List<Tareas> lista){
        foreach (Tareas tarea in lista)
        {
            Console.WriteLine(tarea.Id);
            Console.WriteLine(tarea.Descripcion);
            Console.WriteLine(tarea.Duracion);
        }
}