import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';

export class Products{
  Sn:number=0;
  Product!:string;
  Description!:string;
  Created!:Date;
}
@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  constructor(private http:HttpClient) { }
  GetProducts():any{
    return this.http.get("https://localhost:44303/api/Product/api/GetProducts");
  }
  SaveProducts(pro:Products):any{
    return this.http.post("https://localhost:44303/api/Product/api/AddProducts",pro);
  }
  UpdateProducts(pro:Products):any{
    return this.http.put("https://localhost:44303/api/Product/api/UpdateProducts",pro);
  }
  DeleteProducts(Id:number):any{
    return this.http.delete("https://localhost:44303/api/Product/api/Deleteproducts?Id="+Id);
  }
  GetProductsById(Id:number):any{
    return this.http.get("https://localhost:44303/api/Product/api/GetProducttblById?Id="+Id);
  }
}
 