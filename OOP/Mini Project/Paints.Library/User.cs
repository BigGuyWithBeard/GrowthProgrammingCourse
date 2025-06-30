namespace Paints.Library
{
    public class User:IUser
    {
        public User(string name, Guid id)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Id cannot be empty.", nameof(id));
            }
            Name = name;
            Id = id;
        }

        public string Name { get; }
        public Guid Id { get; }

        }
}
