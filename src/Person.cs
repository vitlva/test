using System;

namespace persons {

class Person {
	int id;
	public int Id {
		get { return id; }
	}
		
	string name;
	public string Name {
		get { return name; }
		set { name = value; }
	}
	
	public Person(int id, string name) {
		this.id = id;
		this.name = name;
	}
	
	public override string ToString() {
		return id+" "+name;
	}
	
	public override bool Equals(object o) {
		if (! (o is Person) )
			return false;
		Person p = (o as Person);
		return this.ToString().Equals(p.ToString());
	}

	public override int GetHashCode() {
		return this.ToString().GetHashCode();
	}
	
	static public bool operator ==(Person p1, Person p2) {		
		return p1.Equals(p2);
	}

	static public bool operator !=(Person p1, Person p2) {		
		return !p1.Equals(p2);
	}
}

}
