using SimpleToDo.Domain.Exceptions;
using SimpleToDo.Domain.ValueObjects;

namespace SimpleToDo.Domain.UnitTest.ValueObjects;

public class ToDoItemTitleTests
{
    [Fact]
    public void WhitespaceTitleShouldThrowsException()
    {
        const string twoWhiteSpaceName = "   ";

        var ex = Assert.Throws<WhitespaceTodoItemTitleException>(() => new TodoItemTitle(twoWhiteSpaceName));

        Assert.Equal("Todo Item Title is whitespaces", ex.Message);
    }

    [Fact]
    public void EmptyTitleShouldThrowsException()
    {
        var ex = Assert.Throws<EmptyTodoItemTitleException>(() => new TodoItemTitle(string.Empty));

        Assert.Equal("Todo Item Title is empty", ex.Message);
    }

    [Fact]
    public void TodoItemTitleShouldBeConvertedToString()
    {
        const string titleName = "TodoItemTitle";
        var todoItemTitle = new TodoItemTitle(titleName);

        Assert.IsType<string>((string) todoItemTitle);
        Assert.Equal(titleName, (string) todoItemTitle);
    }

    [Fact]
    public void StringShouldBeConvertedToToDoItemTitle()
    {
        const string titleName = "TodoItemTitle";

        Assert.IsType<TodoItemTitle>((TodoItemTitle) titleName);
        Assert.Equal(titleName, ((TodoItemTitle) titleName).Value);
    }
}