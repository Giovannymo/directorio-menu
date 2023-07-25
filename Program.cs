


internal class Program{

  public static void Main(string[] args){

    Dictionary<string, int> directorio = new Dictionary<string, int>();
    bool next = true;

    void AddContact(){
      Console.Write("Ingrese el nombre del contacto: ");
      string ? name = Console.ReadLine();
      Console.Write("Ingrese el número del contacto: ");
      int number = int.Parse(Console.ReadLine());
      directorio.Add(name, number);
    }


    void ShowContacts(){
      
    }





    do{
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("\n ========== MENÚ ========== \n");
      Console.ResetColor();
      Console.Write("1.Agregar nuevo número. \n"+
                    "2.Mostrar todos los números. \n"+
                    "3.Marcar un número como importante. \n"+
                    "4.Eliminar número. \n \n"+
                    "0.Salir.\n");

      int ? select = int.Parse(Console.ReadLine());

      switch(select){
        case 1:
            AddContact();
        break;
        case 0: 
            next = false;
          break;
      }


      
    }while(next);






  }


}