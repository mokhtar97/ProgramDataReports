import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/ProductServices/product.service';
import { Product } from 'src/app/shared/product';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {

  public Products: Product[] = [] ;

  public Programs: any[] = [] ;

  public Reports: any[] = [] ;

  public Parameters: any[] = [] ;

  public AllData: any[] = [] ;

  public Currentpage: number = 1;
  constructor(private prdserv: ProductService ) { }

  columnDefs = [
    {headerName: 'ID', field: 'id' , sortable: true , filter : true},
    {headerName: 'Name', field: 'name' , sortable: true , filter : true},
    {headerName: 'Price', field: 'price', sortable: true , filter : true}
];

columnDefs2 = [
  {headerName: 'ID', field: 'id' , sortable: true , filter : true},
  {headerName: 'EnglishName', field: 'englishName' , sortable: true , filter : true},
  {headerName: 'ArabicName', field: 'arabicName', sortable: true , filter : true}
];


columnDefs3 = [
  {headerName: 'ProgID', field: 'progID' , sortable: true , filter : true},
  {headerName: 'progarmEnglishName', field: 'progarmEnglishName' , sortable: true , filter : true},
  {headerName: 'progarmArabicName', field: 'progarmArabicName', sortable: true , filter : true},

  {headerName: 'repID', field: 'repID' , sortable: true , filter : true},
  {headerName: 'reportEnglishName', field: 'reportEnglishName' , sortable: true , filter : true},
  {headerName: 'reportArabicName', field: 'reportArabicName', sortable: true , filter : true},
  {headerName: 'repprogID', field: 'repprogID' , sortable: true , filter : true},

  {headerName: 'paramID', field: 'paramID' , sortable: true , filter : true},
  {headerName: 'parameterEnglishName', field: 'parameterEnglishName' , sortable: true , filter : true},
  {headerName: 'parameterArabicName', field: 'parameterArabicName', sortable: true , filter : true},
  {headerName: 'paramrepID', field: 'paramrepID' , sortable: true , filter : true},
];

  ngOnInit(): void {
    this.getAllProducts();
    this.getAllPrograms();
    this.getAllReports();
    this.getAllParameters();
    this.getAllViewData(this.Currentpage);
  }

  getAllProducts()
  {
    this.prdserv.getProducts().subscribe(
      res => {this.Products = res ; console.log(res)},
      err => console.log(err)
    );
  }

  getAllPrograms()
  {
    this.prdserv.getPrograms().subscribe(
      res => {this.Programs = res ; console.log(res)},
      err => console.log(err)
    );
  }


  getAllReports()
  {
    this.prdserv.getReports().subscribe(
      res => {this.Reports = res ; console.log(res)},
      err => console.log(err)
    );
  }

  getAllParameters()
  {
    this.prdserv.getParameters().subscribe(
      res => {this.Parameters = res ; console.log(res)},
      err => console.log(err)
    );
  }

  getAllViewData(pagenumber:number)
  {
    this.prdserv.getViewData(pagenumber).subscribe(
      res => {this.AllData = res ; console.log(res)},
      err => console.log(err)
    );
  }

  next()
  {
     this.Currentpage++;
     this.getAllViewData(this.Currentpage);
     
  }
  prev()
  {
    this.Currentpage--;
    this.getAllViewData(this.Currentpage);
  }
}
