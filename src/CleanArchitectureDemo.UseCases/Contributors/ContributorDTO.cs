namespace CleanArchitectureDemo.UseCases.Contributors;
public record ContributorDTO(int Id, string Name)
{
    public int Id { get; set; } = Id;
    public string Name { get; set; } = Name;
}
