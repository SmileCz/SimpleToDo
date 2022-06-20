using SimpleToDo.Core.Exceptions;
using SimpleToDo.Core.ValueObjects;

namespace SimpleToDo.Domain.UnitTest.ValueObjects;


public class ToDoItemTitleTests
{
    [Fact]
    public void WhitespaceNameShouldThrowEmptyToDoItemTitleException()
    {
        const string twoWhiteSpaceName = "   ";

        var ex = Assert.Throws<EmptyTodoItemTitleException>(() => new ToDoItemTitle(twoWhiteSpaceName));
        
        Assert.Equal("Todo Item Title is empty or whitespaces",ex.Message);
    }

    [Fact]
    public void TodoItemTitleShouldBeConvertedToString()
    {

        const string titleName = "TodoItemTitle";
        var todoItemTitle = new ToDoItemTitle(titleName);
        
        Assert.IsType<string>((string)todoItemTitle);
        Assert.Equal(titleName,(string)todoItemTitle);
    }

    [Fact]
    public void StringShouldBeConvertedToToDoItemTitle()
    {
        const string titleName = "TodoItemTitle";
        
        Assert.IsType<ToDoItemTitle>((ToDoItemTitle)titleName);
        Assert.Equal(titleName,((ToDoItemTitle)titleName).Value);
    }
}