namespace LibraryManagement.Core.ErrorHandling
{
    public abstract class Result
    {
        public abstract bool Success {get; }
    }
    public class SuccessResult : Result
    {
        public override bool Success {get{return true;}}
        public string Error { get;}

        public SuccessResult(string error)
        {
            Error = error;
        }

        // public SuccessResult Ok()
        // {
        //     return new SuccessResult(true,string.Empty);
        // }
    }
}