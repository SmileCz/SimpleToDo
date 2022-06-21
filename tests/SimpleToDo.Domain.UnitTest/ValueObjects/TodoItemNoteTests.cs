using SimpleToDo.Domain.Exceptions;
using SimpleToDo.Domain.ValueObjects;

namespace SimpleToDo.Domain.UnitTest.ValueObjects;

public class TodoItemNoteTests
{
    [Fact]
    public void WhitespaceTodoItemNoteShouldThrowsException()
    {
        const string twoWhiteSpace = "  ";
        var ex = Assert.Throws<WhitespaceTodoItemNoteException>(() => new TodoItemNote(twoWhiteSpace));
        
        Assert.Equal("Todo Item Note is whitespaces",ex.Message);
    }

    [Fact]
    public void EmptyTodoItemNoteShouldThrowsException()
    {
        var ex = Assert.Throws<EmptyTodoItemNoteException>(() => new TodoItemNote(string.Empty));
        
        Assert.Equal("Todo Item Note is empty",ex.Message);
    }

    [Fact]
    public void TodoItemNoteShouldBeConvertedToString()
    {
        const string noteText = "Note";
        var todoItemNote = new TodoItemNote(noteText);

        Assert.IsType<string>((string) todoItemNote!);
        Assert.Equal(noteText,(string)todoItemNote!);
    }

    [Fact]
    public void StringShouldBeConvertedToTodoItemNote()
    {
        Assert.IsType<TodoItemNote>((TodoItemNote)"TEST");
        Assert.Equal("TEST", ((TodoItemNote) "TEST").Value);

    }
}