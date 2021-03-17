function Product(title,price){
    this.title=title;
    this.price=price;

}
Product.prototype.owmer="foo";
Product.prototype.displayProduct = function(){
    console.log(this);
}
let p1=new Product("p1",900);
let p2=new Product("p2",300);
p1.displayProduct=function(){
    console.log(this);
    console.log(this.owmer);
}
p1.displayProduct();
p2.displayProduct();
p1.displayProduct.call(p2);
