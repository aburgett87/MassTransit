namespace MassTransit
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Individual turnout jobs are tracked by this state
    /// </summary>
    public class JobSaga :
        SagaStateMachineInstance,
        ISagaVersion
    {
        public int CurrentState { get; set; }

        public DateTime? Submitted { get; set; }
        public Uri ServiceAddress { get; set; }
        public TimeSpan? JobTimeout { get; set; }
        public IDictionary<string, object> Job { get; set; }
        public Guid JobTypeId { get; set; }

        public Guid AttemptId { get; set; }
        public int RetryAttempt { get; set; }

        public DateTime? Started { get; set; }

        public DateTime? Completed { get; set; }
        public TimeSpan? Duration { get; set; }

        public DateTime? Faulted { get; set; }
        public string Reason { get; set; }

        public Guid? JobSlotWaitToken { get; set; }
        public Guid? JobRetryDelayToken { get; set; }

        /// <summary>
        /// For recurring jobs, the cron expression used to determine the next start date after the job has completed.
        /// </summary>
        public string CronExpression { get; set; }

        /// <summary>
        /// The time zone for the cron expression
        /// </summary>
        public string TimeZoneId { get; set; }

        /// <summary>
        /// If a state date is specified, the job won't start until after the start date.
        /// </summary>
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// For recurring jobs, if the <see cref="NextStartDate"/> is after the end date the job will be completed.
        /// </summary>
        public DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// For recurring jobs, the next start date based on the cron expression (and <see cref="StartDate"/>, if specified).
        /// </summary>
        public DateTimeOffset? NextStartDate { get; set; }

        public byte[] RowVersion { get; set; }

        public int Version { get; set; }

        public Guid CorrelationId { get; set; }
    }
}
