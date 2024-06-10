namespace Spg.Spengergram.DomainModel.Model
{
    public enum ReactionType 
    {
        // https://www.engagebay.com/blog/emojis-with-meaning/
        Smile, Laughing, LaughingCrying, BlushingSmileyFaceWithHearts, HeartShapedEyesFace,
        Mad, Hug, AstonishedFace, EyeRoll, DisappointedFace, NerdFace, ThumbsUp, RedHeart
    }

    public class Reaction
    {
        public int Id { get; }
        public ReactionType ReactionType { get; set; }

        // Navigations
        public User UserNavigation { get; set; } = default!;
        public Message MessageNavigation { get; set; } = default!;
    }
}
