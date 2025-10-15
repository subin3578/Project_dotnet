<h2 data-ke-size="size26"><b>📘 ASP.NET Core MVC + MySQL 게시판 만들기</b></h2>
</br>
<h2 data-ke-size="size26"><b>EF Core + MySQL 세팅</b></h2>
<h4 data-ke-size="size20"><b>EF Core(Entity Framework Core)</b></h4>
<p data-ke-size="size16">&rarr; .NET에서 사용하는 ORM(Object-Relational Mapping) 프레임워크이다.</p>
<p data-ke-size="size16">ORM은 객체와 데이터베이스의 테이블을 연결해주는 기술로, SQL문을 직접 작성하지 않아도 CRUD가 가능하다.</p>
<p data-ke-size="size16"><span style="color: #9d9d9d;">(SpringBoot의 JPA 개념과 유사)</span></p>
<p data-ke-size="size16">&nbsp;</p>
<h3 data-ke-size="size23"><b>+) 제공자(Provider)의 역할</b></h3>
<p data-ke-size="size16">EF Core는 단독으로는 &ldquo;ORM의 틀&rdquo;일 뿐</p>
<p data-ke-size="size16">&rarr; &ldquo;어떤 DB를 쓸 것인가&rdquo;는 <span><b>제공자(Provider)</b></span> 가 담당한다.</p>
<ul style="list-style-type: disc;" data-ke-list-type="disc">
<li>SQLite, SQL Server, MySQL, PostgreSQL</li>
</ul>
<hr data-ke-style="style1" />
<p data-ke-size="size16">&nbsp;</p>
<h3 data-ke-size="size23"><b>MySQL용 패키지 설치</b></h3>
<pre class="ada"><code>dotnet add package MySql.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design</code></pre>
<p data-ke-size="size16">&nbsp;</p>

<h2 data-ke-size="size26"><b>실행 결과 화면</b></h2>
<p data-ke-size="size16">&nbsp;</p>
<img width="2458" height="1666" alt="image" src="https://github.com/user-attachments/assets/c8c9702d-2d86-4110-b5c7-743ef23d77a6" />
<img width="2400" height="1730" alt="image" src="https://github.com/user-attachments/assets/c4ce7a09-673e-4f38-b732-b8d86a14e8c9" />
<img width="2410" height="1550" alt="image" src="https://github.com/user-attachments/assets/b813a695-3ec6-41fa-abfc-c2288def9adb" />
<img width="2418" height="1580" alt="image" src="https://github.com/user-attachments/assets/e42d554b-b372-43b4-8803-b20ead7e42c8" />


