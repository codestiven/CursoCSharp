try
{
    int[] notas = { 7, 5, 2, 10 };
    Console.WriteLine(notas[11]);
}
catch (Exception e)
{
	Console.WriteLine(e);
	throw;
}
finally
{
    Console.WriteLine("finalizo");
}

