using BlasII.StylePoints.Utils;
using UnityEngine;

namespace BlasII.StylePoints.Ratings;

/// <summary>
/// Implements the Manager abstract class to store Ratings.
/// </summary>
public class RatingsManager : Manager<RatingID, Rating>
{
	/* Methods */

	/// <summary>
	/// Adds a new rating constructed from the given parameters to the managed
	/// values.
	/// </summary>
	public Rating Add(
		RatingID id,
		string name,
		Color color,
		int minimumStyle,
		RatingID? previousRatingID,
		RatingID? nextRatingID
	)
	{
		Rating rating = new (
			id,
			text: new (name, color),
			minimumStyle: minimumStyle,
			previousRatingID: previousRatingID,
			nextRatingID: nextRatingID
		);
		this[id] = rating;
		return rating;
	}

	/// <summary>
	/// Fills the static data.
	/// </summary>
	protected override void Fill()
	{
	// I know what i am doing :D
		Add(RatingID.D, "Eviterno", Color.cyan, 1, null, RatingID.C);
		Add(RatingID.C, "Markus", Color.green, 50, RatingID.D, RatingID.B);
		Add(RatingID.B, "Oisin", Color.yellow, 150, RatingID.C, RatingID.A);
		Add(RatingID.A, "Anddessine", new Color(0.75f, 0.5f, 0f, 1f), 300, RatingID.B, RatingID.S);
		Add(RatingID.S, "Druh", Color.red, 500, RatingID.A, RatingID.SS);
		Add(RatingID.SS, "Qwasker", Color.red, 1000, RatingID.S, RatingID.SSS); // LMAO :D
		Add(RatingID.SSS, "Shadow Moses", Color.red, 2000, RatingID.SS, null);
	}
}

