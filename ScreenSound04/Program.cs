using (HttpClient cliente = new HttpClient())
{
    string resposta = cliente.GetStringAsync("");
}