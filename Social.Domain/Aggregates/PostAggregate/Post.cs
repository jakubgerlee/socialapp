﻿using Social.Domain.Aggregates.UserProfileAggregate;

namespace Social.Domain.Aggregates.PostAggregate;

public class Post
{
	private readonly List<PostComment> _comments = new();
	private readonly List<PostInteraction> _interactions = new();

	private Post() { }

	public Guid PostId { get; private set; }
	public Guid UserProfileId { get; private set; }
	public UserProfile UserProfile { get; private set; }
	public string TextContent { get; private set; }
	public DateTime CreatedDate { get; private set; }
	public DateTime LastModified { get; private set; }
	public IEnumerable<PostComment> Comments => _comments;
    public IEnumerable<PostInteraction> Interactions => _interactions;

    // Factory methods
	public static Post CreatePost(Guid userProfileId, string textContent)
	{
		return new Post
		{
			UserProfileId = userProfileId,
			TextContent = textContent,
			CreatedDate = DateTime.UtcNow,
			LastModified = DateTime.UtcNow
		};
	}

	//public methods
	public void UpdatePostText(string newText)
	{
		TextContent = newText;
		LastModified = DateTime.UtcNow;
	}

	public void PostComment(PostComment postComment)
	{
		_comments.Add(postComment);
	}

	public void RemoveComment(PostComment toRemove)
	{
		_comments.Remove(toRemove);
	}

	public void AddInteraction(PostInteraction newInteraction)
	{
		_interactions.Add(newInteraction);
	}

	public void RemoveInteraction(PostInteraction toRemove)
	{
		_interactions.Remove(toRemove);
	}
}
