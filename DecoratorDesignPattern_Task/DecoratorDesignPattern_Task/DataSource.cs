namespace DecoratorDesignPattern_Task;

public interface DataSource
{
    public void writeData(string data);
    public void readData();
}

public class FileDataSource : DataSource
{
    private string fileName;

    public FileDataSource(string fileName)
    {
        this.fileName = fileName;
    }

    public void readData()
    {
        Console.WriteLine("Read Data");
    }

    public void writeData(string data)
    {
        Console.WriteLine("Write Data");
    }
}

public class DataSourceDecorator : DataSource
{
    private DataSource wrappee;

    public DataSourceDecorator(DataSource wrappee)
    {
        this.wrappee = wrappee;
    }

    public void readData()
    {
        Console.WriteLine("Read Data");
    }

    public void writeData(string data)
    {
        Console.WriteLine("Write Data");
    }
}

public class EncyrptionDecorator : DataSourceDecorator
{
    public EncyrptionDecorator(DataSource wrappee) : base(wrappee)
    {

    }

    public void readData()
    {
        Console.WriteLine("Read Data");
    }

    public void writeData(string data)
    {
        Console.WriteLine("Write Data");
    }
}

public class CompressionDecorator : DataSourceDecorator
{
    public CompressionDecorator(DataSource wrappee) : base(wrappee)
    {

    }

    public void readData()
    {
        Console.WriteLine("Read Data");
    }

    public void writeData(string data)
    {
        Console.WriteLine("Write Data");
    }
}