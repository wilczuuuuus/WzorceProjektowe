using ObserverExam;

var lecturer = new Lecturer();

var jan = new Student("Jan Kowalski");
var anna = new Student("Anna Nowak");
var piotr = new Student("Piotr Wiśniewski");

lecturer.AddStudent(jan, 5);
lecturer.AddStudent(anna, 4);
lecturer.AddStudent(piotr, 3);

lecturer.AnnounceResults();
