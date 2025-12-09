namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Editor _gEditor  = new Editor();
            CommandHistory _history = new CommandHistory();

            App _app = new App(_history, _gEditor);

            Command _addCircle = new AddCircleShape(_gEditor, _app);
            Command _addTriangle = new AddTriangleShape(_gEditor, _app);
            Command _addSquare = new AddCircleShape(_gEditor, _app);
            Command _Undo = new Undo(_gEditor, _app);


            _app.ExecuteCommand(_addSquare);
            _app.ExecuteCommand(_addTriangle);
            _app.ExecuteCommand(_addCircle);
            _app.ExecuteCommand(_Undo); 

        }
    }
}
