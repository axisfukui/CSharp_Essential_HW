namespace Lesson04_LW01_v02
{
    class Human
    {
        public Human(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }

        public void MoveOn (IMovable movable)
        {
            movable.Move();
        }
    }
}
