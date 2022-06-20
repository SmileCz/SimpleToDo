using SimpleToDo.Shared.Abstraction.Exceptions;

namespace SimpleToDo.Core.Exceptions;

public class EmptyTodoItemTitleException : SimpleToDoException

{
    public EmptyTodoItemTitleException()
    :base("Todo Item Title is empty")
    { 
        
    }
}