namespace Caesars_Pokemon_TBuilder.model
{
    public class Pokemon_Entity
    {
        private string name { get; init; }
        private string entry_description { get; init; }

        private string pokedex_id { get; init; } //Pokemon API data forwarding

        private Pokemon_Typing type { get; init; }

    }
}
