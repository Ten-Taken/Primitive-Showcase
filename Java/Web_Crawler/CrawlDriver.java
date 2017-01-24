class CrawlDriver{

  public static void main(String[] args){
    CrawlRunner obj = new CrawlRunner();
    
    if(args.length==0){
      
      obj.run("http://www.stackoverflow.com");
    }else{
      obj.run(args[0]);
    }
  }
  
}

