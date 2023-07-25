


internal class Program{

  public static void Main(string[] args){

    List<Dictionary<string, int>> directory = new List<Dictionary<string, int>>();
    bool next = true;

    void AddContact(){
      Dictionary<string, int> contact = new Dictionary<string, int>();
      Console.Write("Ingrese el nombre del contacto: ");
      string ? name = Console.ReadLine();
      Console.Write("Ingrese el número del contacto: ");
      int number = int.Parse(Console.ReadLine());
      contact.Add(name, number);
      directory.Add(contact);
    }


    void ShowContacts(){
      Console.WriteLine("NOMBRE:       #");
      foreach(var contacts in directory){
        foreach(var contact in contacts){
          Console.WriteLine($"{contact.Key} {contact.Value}");
        }
      }
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
        case 2: 
            ShowContacts();           
        break;
        case 0: 
            next = false;
        break;
      }


      
    }while(next);






  }


}