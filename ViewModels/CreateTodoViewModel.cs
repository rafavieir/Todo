using Flunt.Notifications;
using MINITODO.Models;
using MINITODO.Data;
using MINITODO.ViewModels;
using Flunt.Validations;

namespace MINITODO.ViewModels

{
    public class CreateTodoViewModel : Notifiable<Notification>
    {
        public string Title {get; set;}
        
        public Todo MapTo()
        {
            var contract = new Contract <Notification>()
                .Requires()
                .IsNotNull(Title, "Informe o Título da tarefa")
                .IsGreaterThan(Title,5,"O título deve conter mais de 5 letras");
            AddNotifications(contract);
            return new Todo(Guid.NewGuid(),Title,false);
        }
    }
} 