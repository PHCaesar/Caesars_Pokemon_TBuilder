namespace Caesars_Pokemon_TBuilder.model
{
    public class Pokemon_Team
    {

        /*
         * User the team belongs to
         */
        private User user;
        /*
         * Saving entities in a team
         */
        private IList<Pokemon_Entity> _entity { get; init; }
    }
}
