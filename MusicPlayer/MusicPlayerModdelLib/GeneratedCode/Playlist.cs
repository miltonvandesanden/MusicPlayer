﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Playlist
{
	public virtual string Name
	{
		get;
		set;
	}

	public virtual IEnumerable<Song> Song
	{
		get;
		set;
	}

	public Playlist(string name)
	{
	}

	public virtual void Add(Song song)
	{
		throw new System.NotImplementedException();
	}

	public virtual void Add(List<Song> songs)
	{
		throw new System.NotImplementedException();
	}

	public virtual void Remove(Song song)
	{
		throw new System.NotImplementedException();
	}

	public virtual string ToString()
	{
		throw new System.NotImplementedException();
	}

}

