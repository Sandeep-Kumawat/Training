function Animal(owner){
    this.owner = owner;
}
var a = new Animal('foo');
function Dog(name, color){
    this.name = name;
    this.color = color;
}
var d = new Dog('German','Grey');
d.__proto__ = a;
console.log(d.owner);