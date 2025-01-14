namespace MassTransit.Contracts.JobService
{
    using System;


    public interface JobState
    {
        /// <summary>
        /// The job identifier
        /// </summary>
        Guid JobId { get; }

        /// <summary>
        /// When the job was submitted
        /// </summary>
        DateTime? Submitted { get; }

        /// <summary>
        /// When the job was started, if it has started
        /// </summary>
        DateTime? Started { get; }

        /// <summary>
        /// When the job completed, if it completed
        /// </summary>
        DateTime? Completed { get; }

        /// <summary>
        /// If the job has completed, the duration of the job
        /// </summary>
        TimeSpan? Duration { get; }

        /// <summary>
        /// When the job faulted, if it faulted
        /// </summary>
        DateTime? Faulted { get; }

        /// <summary>
        /// The fault reason, if it faulted
        /// </summary>
        string Reason { get; }

        /// <summary>
        /// If the job has been retried, will be > 0
        /// </summary>
        int LastRetryAttempt { get; }

        /// <summary>
        /// The current job state
        /// </summary>
        string CurrentState { get; }

        /// <summary>
        /// If present, the next scheduled time for the job to run
        /// </summary>
        DateTime? NextStartDate { get; }

        /// <summary>
        /// True if the job is a recurring job
        /// </summary>
        bool IsRecurring { get; }

        /// <summary>
        /// If specified, the start date or the start of the data range (for recurring jobs) when the job should be run
        /// </summary>
        DateTime? StartDate { get; }

        /// <summary>
        /// If specified, the end of the data range (for recurring jobs) when the job should no longer be run
        /// </summary>
        DateTime? EndDate { get; }
    }
}
