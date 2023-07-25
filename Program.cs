


internal class Program{

  public static void Main(string[] args){

    List<Dictionary<string, int>> directory = new List<Dictionary<string, int>>();
    List<Dictionary<string, int>> directoryImportant = new List<Dictionary<string, int>>();

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


    void ShowContacts(List<Dictionary<string, int>> directory){
      Console.WriteLine("NOMBRE: ");
      foreach(var contacts in directory){
        Console.Write((directory.IndexOf(contacts)+1)+". ");
        foreach(var contact in contacts){
          Console.WriteLine($"{contact.Key}   # {contact.Value}");
        }
      }
    }


    void ImportantSelect(){
      Console.Write("Digite la posicion del nùmero a marcar: ");
      int ? select = int.Parse(Console.ReadLine());

      foreach(var contacts in directory){
        if((directory.IndexOf(contacts)+1) == select){
            directoryImportant.Add(contacts);
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

      int ? select = i
      
      
      
      
      
     
     
     
      nt.Parse(Console.ReadLine());

      switch(select){
        case 1:
          AddContact();
        break;
        case 2: 
          ShowContacts();           
        break;
        case 3:
          AddContact();          
        break;
        case 0: 
            next = false;
        break;
      }
      
    }while(next);

  }

}