namespace Blog.ViewModel
{
    public class ResultViewModel<T>
    {
        //Quando houver o dado e a lista de erros.
        public ResultViewModel(T data, List<string> errors)
        {
            Data = data;
            Errors = errors;
        }

        //Quando houver sucesso.
        public ResultViewModel(T data)
        {
            Data=data;
        }

        // Quando houver erros.
        public ResultViewModel(List<string> errors)
        {
            Errors = errors;
        }

        // Quando houver somente um erro.
        public ResultViewModel(string error)
        {
            Errors.Add(error);
        }

        public T Data { get; private set; }
        public List<string> Errors { get; private set; } = new();

    }
}
