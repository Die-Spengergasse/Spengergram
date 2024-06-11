﻿namespace Spg.Spengergram.DomainModel.Model
{
    public enum Emoji 
    {
        // https://www.engagebay.com/blog/emojis-with-meaning/
        // https://emojiisland.com/pages/download-new-emoji-icons-in-png-ios-10
        Smile, Laughing, LaughingCrying, BlushingSmileyFaceWithHearts, HeartShapedEyesFace,
        Mad, Hug, AstonishedFace, EyeRoll, DisappointedFace, NerdFace, ThumbsUp, RedHeart
    }

    public class Reaction
    {
        public int Id { get; }
        public Emoji ReactionType { get; set; }

        // Navigations
        public User UserNavigation { get; set; } = default!;
        public Message MessageNavigation { get; set; } = default!;
    }
}
