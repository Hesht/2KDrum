using System;
using System.Collections.Generic;
using GameSparks.Core;
using GameSparks.Api.Requests;
using GameSparks.Api.Responses;

//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!
//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!
//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!

namespace GameSparks.Api.Requests{
}
	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_2KAR : GSTypedRequest<LeaderboardDataRequest_2KAR,LeaderboardDataResponse_2KAR>
	{
		public LeaderboardDataRequest_2KAR() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "2KAR");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_2KAR (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_2KAR SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_2KAR SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_2KAR SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_2KAR SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_2KAR SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_2KAR SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_2KAR SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_2KAR SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_2KAR SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_2KAR : GSTypedRequest<AroundMeLeaderboardRequest_2KAR,AroundMeLeaderboardResponse_2KAR>
	{
		public AroundMeLeaderboardRequest_2KAR() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "2KAR");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_2KAR (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_2KAR SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_2KAR SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_2KAR SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_2KAR SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_2KAR SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_2KAR SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_2KAR SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_2KAR : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_2KAR(GSData data) : base(data){}
	}
	
	public class LeaderboardDataResponse_2KAR : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_2KAR(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_2KAR> Data_2KAR{
			get{return new GSEnumerable<_LeaderboardEntry_2KAR>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_2KAR(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_2KAR> First_2KAR{
			get{return new GSEnumerable<_LeaderboardEntry_2KAR>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_2KAR(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_2KAR> Last_2KAR{
			get{return new GSEnumerable<_LeaderboardEntry_2KAR>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_2KAR(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_2KAR : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_2KAR(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_2KAR> Data_2KAR{
			get{return new GSEnumerable<_LeaderboardEntry_2KAR>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_2KAR(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_2KAR> First_2KAR{
			get{return new GSEnumerable<_LeaderboardEntry_2KAR>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_2KAR(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_2KAR> Last_2KAR{
			get{return new GSEnumerable<_LeaderboardEntry_2KAR>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_2KAR(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_2KSL : GSTypedRequest<LeaderboardDataRequest_2KSL,LeaderboardDataResponse_2KSL>
	{
		public LeaderboardDataRequest_2KSL() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "2KSL");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_2KSL (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_2KSL SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_2KSL SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_2KSL SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_2KSL SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_2KSL SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_2KSL SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_2KSL SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_2KSL SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_2KSL SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_2KSL : GSTypedRequest<AroundMeLeaderboardRequest_2KSL,AroundMeLeaderboardResponse_2KSL>
	{
		public AroundMeLeaderboardRequest_2KSL() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "2KSL");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_2KSL (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_2KSL SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_2KSL SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_2KSL SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_2KSL SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_2KSL SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_2KSL SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_2KSL SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_2KSL : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_2KSL(GSData data) : base(data){}
	}
	
	public class LeaderboardDataResponse_2KSL : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_2KSL(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_2KSL> Data_2KSL{
			get{return new GSEnumerable<_LeaderboardEntry_2KSL>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_2KSL(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_2KSL> First_2KSL{
			get{return new GSEnumerable<_LeaderboardEntry_2KSL>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_2KSL(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_2KSL> Last_2KSL{
			get{return new GSEnumerable<_LeaderboardEntry_2KSL>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_2KSL(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_2KSL : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_2KSL(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_2KSL> Data_2KSL{
			get{return new GSEnumerable<_LeaderboardEntry_2KSL>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_2KSL(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_2KSL> First_2KSL{
			get{return new GSEnumerable<_LeaderboardEntry_2KSL>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_2KSL(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_2KSL> Last_2KSL{
			get{return new GSEnumerable<_LeaderboardEntry_2KSL>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_2KSL(data);});}
		}
	}
}	

namespace GameSparks.Api.Messages {


}
