namespace BasicClass;

public class User
{
    public string Name { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Alias { get; set; } = string.Empty;
    public string MobilePhone { get; set; } = string.Empty;

    public int ReturnNumericMobile()
    {
        string numericMobile = "";
        //Sacar los caracteres especiales  
        foreach (char ch in this.MobilePhone)
        {
            if (ch != ' ' && ch != '+' && ch != '-')
            {
                numericMobile = numericMobile + ch.ToString();
            }
        }
        //Convertir a 10 digitos  
        if (numericMobile.Length > 10)
        {
            numericMobile = numericMobile.Substring(numericMobile.Length - 10, 10);
        }
        return int.Parse(numericMobile);
    }
}
