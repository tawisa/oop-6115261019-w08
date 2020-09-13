namespace oop_615261019_w08
{
    class Movie
    {
        private string name;
        private string category;
        private string director;
        private Actor actorMovie;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        public Actor ActorMovie
        {
            get { return actorMovie; }
            set { actorMovie = value; }
        }
        public Movie(string n, string ad, string d, Actor am)
        {
            this.name = n;
            this.category = ad;
            this.director = d;
            this.actorMovie = am;

        }
        public override string ToString()
        {
            return this.name + " " +
                 this.category + " " +
                 this.director + " " +
                 this.actorMovie;

        }
    }
}
