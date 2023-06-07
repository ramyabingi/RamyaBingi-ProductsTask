import { Component,OnInit } from '@angular/core';
import { ProductsService } from 'src/app/Services/products.service';
export class Products{
  Sn:number=0;
  Product!:string;
  Description!:string;
  Created!:Date;
}
@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  product:Products=new Products();
 productdata:Products[]=[];
 pid:number=0;
  constructor(private productservice:ProductsService){}
  ngOnInit(): void {
this.GetProducts();
  }
GetProducts():void{
  this.productservice.GetProducts().subscribe(
    (resp:any)=>{
      this.productdata=resp;
    }
  )
}
SaveProducts(pro:Products):void{
  this.productservice.SaveProducts(pro).subscribe(
    (res:any)=>{
alert("Data is Saved");
      this.GetProducts();
      this.product=new Products;
    }
  )
}
UpdateProducts(pro:Products):void{
  this.productservice.UpdateProducts(pro).subscribe(
    (resp:any)=>{
      alert("data is updated");
      this.GetProducts();
      this.product=new Products();
    }
  )
}
DeleteProducts(Id:number):void{
  alert("data is deleted");
  this.productservice.DeleteProducts(Id).subscribe(
    (res:any)=>{
     
      this.productdata=res;
      this.GetProducts();
    }
  )
}
GetProductsById(Id:number):void{
  alert("data is get")
  this.productservice.GetProductsById(Id).subscribe(
    (resp:any)=>{
      this.product=resp;
  
    }
  )
}
}
