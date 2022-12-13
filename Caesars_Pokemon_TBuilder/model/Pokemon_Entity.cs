namespace Caesars_Pokemon_TBuilder.model
{
    public class Pokemon_Entity
    {
        /*
         * pokemons name
         */
        private string name { get; init; }

        /*
         * pokemons description (Pokedex entry)
         */
        private string entry_description { get; init; }

        /*
         * pokemons id -> Pokemon API so that i dont have to save every detail myself
         */
        private string pokedex_id { get; init; } //Pokemon API data forwarding

        /*
         * pokemons type
         */
        private Pokemon_Typing type { get; init; }

    }
}
