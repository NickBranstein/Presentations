namespace Core.Domain;

// lazy data context 
public class DataContext
{
    private Dashboard _dashboard;

    public Dashboard Dashboard => (_dashboard ??= new Dashboard());
}