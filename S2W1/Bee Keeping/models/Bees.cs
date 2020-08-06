namespace Bee_Keeping {
    public class Bee {

        // attributes
        public string Name;
        public float Size;

        // constructor
        public Bee () {
            this.Name = "";
            this.Size = 1;
        }

        // custom constructor
        public Bee (string _Name, float _Size) {
            this.Name = _Name;
            this.Size = _Size;
        }

        // methods
        public void Print () {
            System.Console.WriteLine ();
            System.Console.Write (this.Name);
            System.Console.Write (this.Size);
        }
    }
}