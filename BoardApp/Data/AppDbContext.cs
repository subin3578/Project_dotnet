using Microsoft.EntityFrameworkCore;
using BoardApp.Models;

// 2025/10/15 - DbContext와 DbSet
// 작성자 : 황수빈

// - DbContext: EF Core에서 'DB 연결 관리자' 이자 '작업 단위' - DB 연결과 쿼리, 트랜잭션 등을 관리하는 핵심 클래스
// - DbSet<TEntity>: 특정 엔티티 타입에 대한 CRUD 작업을 수행하는 컬렉션
// - AppDbContext는 DbContext를 상속받아 애플리케이션의 DB 컨텍스트를 정의
// - Posts 속성은 Post 엔티티에 대한 DbSet을 나타내며, 이를 통해 Post 테이블에 접근 가능
// - EF Core는 이 DbSet을 통해 LINQ 쿼리를 작성하고, 데이터를 삽입, 수정, 삭제할 수 있음    

namespace BoardApp.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Post> Posts => Set<Post>();
}