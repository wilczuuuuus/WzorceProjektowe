using AdapterClub;

var club = new Club();
var krzys = new Person("Krzyś");

club.TryEnter(krzys);

var fakeKrzys = new FakeAdult(krzys);
club.TryEnter(fakeKrzys);
