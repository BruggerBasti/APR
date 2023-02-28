namespace SpruchLib
{
    public class Spruch
    {
        List<string> _sprueche = new();

        int counter = 0;

        public void AddSpruch(string spruch)
        {
            _sprueche.Add(spruch);
        }

        public string NextSpruch()
        {
            if(_sprueche.Count == 0)
            {
                throw new SpruchException("Sie haben keinen Spruch in der Liste gespeichert!");
            }

            var temp = counter;
            counter++;

            if (counter == _sprueche.Count)
            {
                counter = 0;
            }

            return _sprueche[temp];
        }
    }
}