<Query Kind="Statements">
  <Connection>
    <ID>173000e8-212c-421d-9354-1c7bff889fb9</ID>
    <NamingServiceVersion>3</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <ConvertUnderscoresToPascal>true</ConvertUnderscoresToPascal>
    <SqlSecurity>true</SqlSecurity>
    <Server>localhost</Server>
    <UserName>testuser</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAhK/21xI5cUemq4w2h641RgAAAAACAAAAAAAQZgAAAAEAACAAAAAIwvcQ8fSqCHZ8EOlSNjYDDsk9ixOKehnLGYDr6PTq+gAAAAAOgAAAAAIAACAAAABscfZNoI0DO/l8w+9v37HIJd40DJxoF1+V97TNiZi8UhAAAABOht3cKPfGecKp8G7yjjMIQAAAAP/NIrUMCei36/SeODueGUFrTcLWmBNNDX6nQ99mVlgL5/NmAHqF9Al4u8ReSkzr6baTiMrhusqqdZ+frrtlv3k=</Password>
    <Database>books</Database>
    <DriverData>
      <EncryptSqlTraffic>True</EncryptSqlTraffic>
      <EFProvider>Pomelo.EntityFrameworkCore.MySql</EFProvider>
      <PreserveNumeric1>True</PreserveNumeric1>
    </DriverData>
  </Connection>
</Query>

var joined = from b in Books
			join ba in Bookauthors on b.ID equals ba.BookId
			join a in Authors on ba.AuthorId equals a.ID
			select new { Book = b.Title, Author = a.FirstName};
			
joined.Dump();