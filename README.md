<?xml version="1.0"?>
<doc>
    <assembly>
        <name>Cron.Core</name>
    </assembly>
    <members>
        <member name="T:Cron.Core.CronBuilder">
            <summary>
            Represents a Cron expression, Description, and object that can be used to create and modify cron expressions.
            Implements the <see cref="T:Cron.Core.Interfaces.ICron" />
            </summary>
            <example>
            Create a Cron object.
            <code>
            schedule = new CronBuilder();
            </code>
            Add Cron sections by section.
            <code>
            schedule.Add(time: CronTimeSections.Seconds, value: seconds, repeatEvery: true)
            schedule.Add(CronTimeSections.Minutes, 4)
            schedule.Add(CronTimeSections.Hours, 3, 5)
            </code>
            Add time sections by months.
            <code>
            schedule.Add(CronMonths.March)
            </code>
            Add time section by Day.
            <code>
            schedule.Add(CronDays.Wednesday)
            </code>
            Chain sections.
            <code>
            schedule = new CronBuilder()
            .Add(CronDays.Friday)
            .Add(CronTimeSections.DayMonth, dayMonth)
            .Add(CronTimeSections.Years, years, true);
            </code>
            Create Cron with an existing expression
            <code>
            var cron = new CronBuilder(expression);
            </code>
            Remove single value entry.
            <code>
            cron.Remove(CronTimeSections.Seconds, 5);
            </code>
            Remove Multiple value entry.
            <code>
            cron.Remove(CronTimeSections.Seconds, 5, 6);
            </code>
            Create Initial Cron with Days
            <code>
            var cron = new CronBuilder
            {
            { CronDays.Thursday, CronDays.Saturday }
            };
            </code>
            Create Initial Cron with Months.
            <code>
            var cron = new CronBuilder { { CronMonths.August, CronMonths.November } };
            </code>
            Reset Day of the Week section only.
            <code>
            cron.Reset(CronTimeSections.DayWeek);
            </code>
            Reset all sections to the defaults.
            <code>
            cron.ResetAll();
            </code></example>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="M:Cron.Core.CronBuilder.#ctor">
            <summary>
            Initializes a new instance of the <see cref="T:Cron.Core.CronBuilder" /> class.
            </summary>
            <example>
            Create a Cron object.
            <code>
            schedule = new CronBuilder();
            </code></example>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="M:Cron.Core.CronBuilder.#ctor(System.String)">
            <summary>
            Initializes a new instance of the <see cref="T:Cron.Core.CronBuilder" /> class.
            </summary>
            <param name="expression">The expression.</param>
            <exception cref="T:System.IO.InvalidDataException">This expression only has {cronArray.Length} parts. An expression must have 5, 6, or 7 parts.</exception>
            <example>
            Create Cron with an existing expression
            <code>
            var cron = new CronBuilder(expression);
            </code></example>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="P:Cron.Core.CronBuilder.DayMonth">
            <summary>
            Day of the Month Information
            </summary>
            <value>The day month.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="P:Cron.Core.CronBuilder.DayWeek">
            <summary>
            Day of the Week Information
            </summary>
            <value>The day week.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="P:Cron.Core.CronBuilder.Description">
            <summary>
            Human readable description.
            </summary>
            <value>The description.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="P:Cron.Core.CronBuilder.Hours">
            <summary>
            Hours Information
            </summary>
            <value>The hours.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="P:Cron.Core.CronBuilder.Minutes">
            <summary>
            Minutes Information
            </summary>
            <value>The minutes.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="P:Cron.Core.CronBuilder.Months">
            <summary>
            Months Information
            </summary>
            <value>The months.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="P:Cron.Core.CronBuilder.Seconds">
            <summary>
            Seconds Information
            </summary>
            <value>The seconds.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="P:Cron.Core.CronBuilder.SectionList">
            <summary>
            Get a list of sections, originally sorted.
            </summary>
            <value>The section list.</value>
        </member>
        <member name="P:Cron.Core.CronBuilder.Value">
            <summary>
            Cron Expression.
            </summary>
            <value>The value.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="P:Cron.Core.CronBuilder.Years">
            <summary>
            Year Information
            </summary>
            <value>The years.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="M:Cron.Core.CronBuilder.Add(Cron.Core.Enums.CronTimeSections,System.Int32,System.Boolean)">
            <summary>
            Add time value for the specified time section.
            </summary>
            <param name="time">The type of time section such as seconds, minutes, etc. See <see cref="T:Cron.Core.Enums.CronTimeSections" />.</param>
            <param name="value">Value for the specified time section.</param>
            <param name="repeatEvery">Indicates if the value is a repeating time or specific time.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
            <exception cref="T:System.ArgumentOutOfRangeException">repeatEvery</exception>
            <exception cref="T:System.ArgumentOutOfRangeException">repeatEvery</exception>
            <example>
            Add Cron sections by section.
            <code>
            schedule.Add(time: CronTimeSections.Seconds, value: seconds, repeatEvery: true)
            schedule.Add(CronTimeSections.Minutes, 4)
            </code></example>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="M:Cron.Core.CronBuilder.Add(Cron.Core.Enums.CronTimeSections,System.Int32,System.Int32)">
            <summary>
            Add time value for the specified time section.
            </summary>
            <param name="time">The type of time section such as seconds, minutes, etc. See <see cref="T:Cron.Core.Enums.CronTimeSections" />.</param>
            <param name="minValue">Starting value for the specified time section.</param>
            <param name="maxValue">Ending value for the specified time section.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
            <example>
            Add Cron sections by section.
            <code>
            schedule.Add(CronTimeSections.Hours, 3, 5);
            schedule.Add(CronTimeSections.Years, 2020, 2022);
            </code></example>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="M:Cron.Core.CronBuilder.Add(Cron.Core.Enums.CronDays)">
            <summary>
            Add day of the week.
            </summary>
            <param name="value"><see cref="T:Cron.Core.Enums.CronDays" /> representing the day of the week.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
            <example>
            Add time section by Day.
            <code>
            schedule.Add(CronDays.Wednesday);
            </code></example>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="M:Cron.Core.CronBuilder.Add(Cron.Core.Enums.CronMonths)">
            <summary>
            Add month.
            </summary>
            <param name="value"><see cref="T:Cron.Core.Enums.CronMonths" /> representing the month.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
            <example>
            Add time sections by months.
            <code>
            schedule.Add(CronMonths.March);
            </code></example>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="M:Cron.Core.CronBuilder.Add(Cron.Core.Enums.CronDays,Cron.Core.Enums.CronDays)">
            <summary>
            Add range of days in the week.
            </summary>
            <param name="minValue">Starting <see cref="T:Cron.Core.Enums.CronDays" /> representing the day of the week.</param>
            <param name="maxValue">Ending <see cref="T:Cron.Core.Enums.CronDays" /> representing the day of the week.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
            <example>
            Add time section by Day.
            <code>
            schedule.Add(CronDays.Wednesday, CronDays.Friday);
            </code></example>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="M:Cron.Core.CronBuilder.Add(Cron.Core.Enums.CronMonths,Cron.Core.Enums.CronMonths)">
            <summary>
            Add range of months.
            </summary>
            <param name="minValue">Starting <see cref="T:Cron.Core.Enums.CronMonths" /> representing the day of the month.</param>
            <param name="maxValue">Ending <see cref="T:Cron.Core.Enums.CronMonths" /> representing the day of the month.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
            <example>
            Add time sections by months.
            <code>
            schedule.Add(CronMonths.March, CronMonths.August);
            </code></example>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="M:Cron.Core.CronBuilder.GetEnumerator">
            <inheritdoc />
        </member>
        <member name="M:Cron.Core.CronBuilder.System#Collections#IEnumerable#GetEnumerator">
            <inheritdoc />
        </member>
        <member name="M:Cron.Core.CronBuilder.Remove(Cron.Core.Enums.CronTimeSections,System.Int32)">
            <summary>
            Remove <see cref="T:Cron.Core.Enums.CronTimeSections" /> with a specified value.
            </summary>
            <param name="time">The type of time section such as seconds, minutes, etc. See <see cref="T:Cron.Core.Enums.CronTimeSections" />.</param>
            <param name="value">Value for the specified time section.</param>
            <returns>ICron.</returns>
            Remove single value entry.
            <code>
            cron.Remove(CronTimeSections.Seconds, 5);
            </code><inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="M:Cron.Core.CronBuilder.Remove(Cron.Core.Enums.CronTimeSections,System.Int32,System.Int32)">
            <summary>
            Remove <see cref="T:Cron.Core.Enums.CronTimeSections" /> with a specified value.
            </summary>
            <param name="time">The type of time section such as seconds, minutes, etc. See <see cref="T:Cron.Core.Enums.CronTimeSections" />.</param>
            <param name="minValue">Starting value for the specified time section.</param>
            <param name="maxValue">Ending value for the specified time section.</param>
            <returns>ICron.</returns>
            Remove Multiple value entry.
            <code>
            cron.Remove(CronTimeSections.Seconds, 5, 6);
            </code><inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="M:Cron.Core.CronBuilder.Reset(Cron.Core.Enums.CronTimeSections)">
            <summary>
            Clear the specific time element of the Cron object to defaults without any numerical cron representations.
            </summary>
            <param name="time">The type of time section such as seconds, minutes, etc. See <see cref="T:Cron.Core.Enums.CronTimeSections" />.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="M:Cron.Core.CronBuilder.Reset(Cron.Core.Interfaces.ISection)">
            <summary>
            Resets the specified section.
            </summary>
            <param name="section"><see cref="T:Cron.Core.Interfaces.ISection" /></param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
        </member>
        <member name="M:Cron.Core.CronBuilder.Reset">
            <summary>
            Clear the entire Cron object to defaults without any numerical cron representations.
            </summary>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="M:Cron.Core.CronBuilder.Set(Cron.Core.Interfaces.ISection)">
            <summary>
            Set time with <see cref="T:Cron.Core.Interfaces.ISection" /> value.
            </summary>
            <param name="value">Value for the specified time section.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="M:Cron.Core.CronBuilder.ToString">
            <summary>
            Returns a <see cref="T:System.String" /> that represents this instance.
            </summary>
            <returns>A <see cref="T:System.String" /> that represents this instance.</returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ICron" />
        </member>
        <member name="T:Cron.Core.Enums.CronDays">
            <summary>
            Day of the week values to build Cron expressions.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronDays.Sunday">
            <summary>
            Sunday.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronDays.Monday">
            <summary>
            Monday.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronDays.Tuesday">
            <summary>
            Tuesday.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronDays.Wednesday">
            <summary>
            Wednesday.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronDays.Thursday">
            <summary>
            Thursday.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronDays.Friday">
            <summary>
            Friday.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronDays.Saturday">
            <summary>
            Saturday.
            </summary>
        </member>
        <member name="T:Cron.Core.Enums.CronMonths">
            <summary>
            Month values used to build Cron expressions.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronMonths.January">
            <summary>
            January.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronMonths.February">
            <summary>
            February.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronMonths.March">
            <summary>
            March.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronMonths.April">
            <summary>
            April.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronMonths.May">
            <summary>
            May.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronMonths.June">
            <summary>
            June.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronMonths.July">
            <summary>
            July.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronMonths.August">
            <summary>
            August.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronMonths.September">
            <summary>
            September.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronMonths.October">
            <summary>
            October.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronMonths.November">
            <summary>
            November.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronMonths.December">
            <summary>
            December.
            </summary>
        </member>
        <member name="T:Cron.Core.Enums.CronSectionType">
            <summary>
            Enum CronSectionType
            </summary>
            <seealso cref="T:Cron.Core.Enums.CronTimeSections" />
        </member>
        <member name="F:Cron.Core.Enums.CronSectionType.Time">
            <summary>
            The time Section Type.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronSectionType.Date">
            <summary>
            The date section Type.
            </summary>
        </member>
        <member name="T:Cron.Core.Enums.CronTimeSections">
            <summary>
            Sections of the Cron indicating the type of time.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronTimeSections.Seconds">
            <summary>
            Seconds.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronTimeSections.Minutes">
            <summary>
            Minutes.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronTimeSections.Hours">
            <summary>
            Hours.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronTimeSections.DayMonth">
            <summary>
            Day of the Month.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronTimeSections.Months">
            <summary>
            Month.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronTimeSections.DayWeek">
            <summary>
            Day of the Week.
            </summary>
        </member>
        <member name="F:Cron.Core.Enums.CronTimeSections.Years">
            <summary>
            Year or interval of years.
            </summary>
            <example>2020,2021.</example>
            <example>2020-2022.</example>
        </member>
        <member name="T:Cron.Core.Interfaces.ICron">
            <summary>
            Cron Interface Object.
            </summary>
        </member>
        <member name="P:Cron.Core.Interfaces.ICron.DayMonth">
            <summary>
            Day of the Month Information
            </summary>
            <value>The day month.</value>
        </member>
        <member name="P:Cron.Core.Interfaces.ICron.DayWeek">
            <summary>
            Day of the Week Information
            </summary>
            <value>The day week.</value>
        </member>
        <member name="P:Cron.Core.Interfaces.ICron.Description">
            <summary>
            Human readable description.
            </summary>
            <value>The description.</value>
            <example>
            Every 22 seconds, every 3,4 minutes, at 03:00 AM through 05:59 AM and 07:00 AM through 11:59 AM, on day 12 of the month, only on
            Wednesday, only in March and May, every 5 years
            </example>
        </member>
        <member name="P:Cron.Core.Interfaces.ICron.Hours">
            <summary>
            Hours Information
            </summary>
            <value>The hours.</value>
        </member>
        <member name="P:Cron.Core.Interfaces.ICron.Minutes">
            <summary>
            Minutes Information
            </summary>
            <value>The minutes.</value>
        </member>
        <member name="P:Cron.Core.Interfaces.ICron.Months">
            <summary>
            Months Information
            </summary>
            <value>The months.</value>
        </member>
        <member name="P:Cron.Core.Interfaces.ICron.Seconds">
            <summary>
            Seconds Information
            </summary>
            <value>The seconds.</value>
        </member>
        <member name="P:Cron.Core.Interfaces.ICron.SectionList">
            <summary>
            Gets the section list.
            </summary>
            <value>The section list.</value>
        </member>
        <member name="P:Cron.Core.Interfaces.ICron.Value">
            <summary>
            Cron Expression.
            </summary>
            <value>The value.</value>
            <example>*/22 */3,4 3-5,7-11 12 3,5 3 */5</example>
        </member>
        <member name="P:Cron.Core.Interfaces.ICron.Years">
            <summary>
            Year Information
            </summary>
            <value>The years.</value>
        </member>
        <member name="M:Cron.Core.Interfaces.ICron.Add(Cron.Core.Enums.CronTimeSections,System.Int32,System.Boolean)">
            <summary>
            Add time value for the specified time section.
            </summary>
            <param name="time">The type of time section such as seconds, minutes, etc. See <see cref="T:Cron.Core.Enums.CronTimeSections" />.</param>
            <param name="value">Value for the specified time section.</param>
            <param name="repeatEvery">Indicates if the value is a repeating time or specific time.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ICron.Add(Cron.Core.Enums.CronTimeSections,System.Int32,System.Int32)">
            <summary>
            Add time value for the specified time section.
            </summary>
            <param name="time">The type of time section such as seconds, minutes, etc. See <see cref="T:Cron.Core.Enums.CronTimeSections" />.</param>
            <param name="minValue">Starting value for the specified time section.</param>
            <param name="maxValue">Ending value for the specified time section.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ICron.Add(Cron.Core.Enums.CronDays)">
            <summary>
            Add day of the week.
            </summary>
            <param name="value"><see cref="T:Cron.Core.Enums.CronDays" /> representing the day of the week.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ICron.Add(Cron.Core.Enums.CronMonths)">
            <summary>
            Add month.
            </summary>
            <param name="value"><see cref="T:Cron.Core.Enums.CronMonths" /> representing the month.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ICron.Add(Cron.Core.Enums.CronDays,Cron.Core.Enums.CronDays)">
            <summary>
            Add range of days in the week.
            </summary>
            <param name="minValue">Starting <see cref="T:Cron.Core.Enums.CronDays" /> representing the day of the week.</param>
            <param name="maxValue">Ending <see cref="T:Cron.Core.Enums.CronDays" /> representing the day of the week.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ICron.Add(Cron.Core.Enums.CronMonths,Cron.Core.Enums.CronMonths)">
            <summary>
            Add range of months.
            </summary>
            <param name="minValue">Starting <see cref="T:Cron.Core.Enums.CronMonths" /> representing the day of the month.</param>
            <param name="maxValue">Ending <see cref="T:Cron.Core.Enums.CronMonths" /> representing the day of the month.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ICron.Remove(Cron.Core.Enums.CronTimeSections,System.Int32)">
            <summary>
            Remove <see cref="T:Cron.Core.Enums.CronTimeSections" /> with a specified value.
            </summary>
            <param name="time">The type of time section such as seconds, minutes, etc. See <see cref="T:Cron.Core.Enums.CronTimeSections" />.</param>
            <param name="value">Value for the specified time section.</param>
            <returns>ICron.</returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ICron.Remove(Cron.Core.Enums.CronTimeSections,System.Int32,System.Int32)">
            <summary>
            Remove <see cref="T:Cron.Core.Enums.CronTimeSections" /> with a specified value.
            </summary>
            <param name="time">The type of time section such as seconds, minutes, etc. See <see cref="T:Cron.Core.Enums.CronTimeSections" />.</param>
            <param name="minValue">Starting value for the specified time section.</param>
            <param name="maxValue">Ending value for the specified time section.</param>
            <returns>ICron.</returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ICron.Reset(Cron.Core.Enums.CronTimeSections)">
            <summary>
            Clear the specific time element of the Cron object to defaults without any numerical cron representations.
            </summary>
            <param name="time">The type of time section such as seconds, minutes, etc. See <see cref="T:Cron.Core.Enums.CronTimeSections" />.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ICron.Reset">
            <summary>
            Clear the entire Cron object to defaults without any numerical cron representations.
            </summary>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ICron.Set(Cron.Core.Interfaces.ISection)">
            <summary>
            Set time with <see cref="T:Cron.Core.Interfaces.ISection" /> value.
            </summary>
            <param name="value">Value for the specified time section.</param>
            <returns><see cref="T:Cron.Core.Interfaces.ICron" /></returns>
        </member>
        <member name="T:Cron.Core.Interfaces.IDateSection">
            <summary>
            Section specifically for Date values.
            </summary>
        </member>
        <member name="T:Cron.Core.Interfaces.ISection">
            <summary>
            Section of time - represents the object for a specific given time element of the Cron expression.
            </summary>
        </member>
        <member name="P:Cron.Core.Interfaces.ISection.Any">
            <summary>
            Indicates that the value should be translated using the ? any indicator.
            </summary>
            <value><c>true</c> if any; otherwise, <c>false</c>.</value>
            <remarks>Experimental.</remarks>
        </member>
        <member name="P:Cron.Core.Interfaces.ISection.ContainsRange">
            <summary>
            Indicates if any values contain a range.
            </summary>
            <value><c>true</c> if [contains range]; otherwise, <c>false</c>.</value>
        </member>
        <member name="P:Cron.Core.Interfaces.ISection.Description">
            <summary>
            Get readable description.
            </summary>
            <value>The description.</value>
        </member>
        <member name="P:Cron.Core.Interfaces.ISection.Enabled">
            <summary>
            Indicates that the value is enabled or used. Equivalent to using ? in a cron expression.
            </summary>
            <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        </member>
        <member name="P:Cron.Core.Interfaces.ISection.Every">
            <summary>
            Indicates that the value should be translated using the */ every indicator.
            </summary>
            <value><c>true</c> if every; otherwise, <c>false</c>.</value>
        </member>
        <member name="P:Cron.Core.Interfaces.ISection.SectionType">
            <summary>
            Gets the type of the section.
            </summary>
            <value>The type of the section.</value>
        </member>
        <member name="P:Cron.Core.Interfaces.ISection.Time">
            <summary>
            Gets the <see cref="T:Cron.Core.Enums.CronTimeSections" />.
            </summary>
            <value>The time.</value>
        </member>
        <member name="P:Cron.Core.Interfaces.ISection.Values">
            <summary>
            List of Cron value expression specific to the <see cref="T:Cron.Core.Interfaces.ISection" />.
            </summary>
            <value>The values.</value>
        </member>
        <member name="M:Cron.Core.Interfaces.ISection.Add(System.Int32)">
            <summary>
            Add time value to this <see cref="T:Cron.Core.Interfaces.ISection" />.
            </summary>
            <param name="value">Value for this <see cref="T:Cron.Core.Interfaces.ISection" />.</param>
            <returns>ISection.</returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ISection.Add(System.Int32,System.Int32)">
            <summary>
            Add a time value range to this <see cref="T:Cron.Core.Interfaces.ISection" />.
            </summary>
            <param name="minVal">Starting value for this <see cref="T:Cron.Core.Interfaces.ISection" />.</param>
            <param name="maxVal">Ending value for this <see cref="T:Cron.Core.Interfaces.ISection" />.</param>
            <returns>ISection.</returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ISection.Clear">
            <summary>
            Clear the values in the <see cref="T:Cron.Core.Interfaces.ISection" />.
            </summary>
            <returns>ISection.</returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ISection.IsInt">
            <summary>
            Indicates if this be represented as an integer.
            </summary>
            <returns><c>true</c> if this instance is int; otherwise, <c>false</c>.</returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ISection.IsValidRange(System.Int32)">
            <summary>
            Checks if the given value is valid for the current <see cref="T:Cron.Core.Interfaces.ISection" />'s <see cref="T:Cron.Core.Enums.CronTimeSections" /> value.
            </summary>
            <param name="value">Value for this <see cref="T:Cron.Core.Interfaces.ISection" />.</param>
            <returns><c>true</c> if [is valid range] [the specified value]; otherwise, <c>false</c>.</returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ISection.Remove(System.Int32)">
            <summary>
            Remove the specified value from the <see cref="T:Cron.Core.Interfaces.ISection" />.
            </summary>
            <param name="value">Value for this <see cref="T:Cron.Core.Interfaces.ISection" />.</param>
            <returns>ISection.</returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ISection.Remove(System.Int32,System.Int32)">
            <summary>
            Remove the specified range of values from the <see cref="T:Cron.Core.Interfaces.ISection" />.
            </summary>
            <param name="minVal">Starting value for this <see cref="T:Cron.Core.Interfaces.ISection" />.</param>
            <param name="maxVal">Ending value for this <see cref="T:Cron.Core.Interfaces.ISection" />.</param>
            <returns>ISection.</returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ISection.ToInt">
            <summary>
            Convert to Integer.
            </summary>
            <returns>System.Int32.</returns>
        </member>
        <member name="M:Cron.Core.Interfaces.ISection.ToString(System.Boolean,System.Type,System.Boolean)">
            <summary>
            Convert to string.
            </summary>
            <param name="translateEnum">Indicates if there is an enumerable, that it should be represented as a string instead of integer.</param>
            <param name="enumType">Type of Enumerable.</param>
            <param name="showEvery">Show every indicator.</param>
            <returns>A <see cref="T:System.String" /> that represents this instance.</returns>
        </member>
        <member name="T:Cron.Core.Interfaces.ISectionValues">
            <summary>
            Stores the values for a section list.
            </summary>
        </member>
        <member name="P:Cron.Core.Interfaces.ISectionValues.MaxValue">
            <summary>
            Maximum value in a value range.
            </summary>
            <value>The maximum value.</value>
        </member>
        <member name="P:Cron.Core.Interfaces.ISectionValues.MinValue">
            <summary>
            Minimum value in a value range. Also represents the only value, if the section is not a range.
            </summary>
            <value>The minimum value.</value>
        </member>
        <member name="M:Cron.Core.Interfaces.ISectionValues.ToString(System.Boolean,System.Type)">
            <summary>
            Convert to a string and translate to Enum, if applicable.
            </summary>
            <param name="translate">Translate values.</param>
            <param name="enumType">Associated Enum Type.</param>
            <returns>A <see cref="T:System.String" /> that represents this instance.</returns>
        </member>
        <member name="T:Cron.Core.Interfaces.ITimeSection">
            <summary>
            Section specifically for Time (seconds, minutes, hours).
            </summary>
        </member>
        <member name="P:Cron.Core.Interfaces.ITimeSection.AllowedIncrements">
            <summary>
            The allowed increments
            </summary>
            <value>The allowed increments.</value>
        </member>
        <member name="T:Cron.Core.Sections.DateSection">
            <summary>
            Class DateSection.
            Implements the <see cref="T:Cron.Core.Sections.Section" />
            Implements the <see cref="T:Cron.Core.Interfaces.IDateSection" />
            </summary>
            <seealso cref="T:Cron.Core.Sections.Section" />
            <seealso cref="T:Cron.Core.Interfaces.IDateSection" />
            <inheritdoc cref="T:Cron.Core.Interfaces.IDateSection" />
        </member>
        <member name="M:Cron.Core.Sections.DateSection.#ctor(Cron.Core.Enums.CronTimeSections,System.String)">
            <inheritdoc />
        </member>
        <member name="M:Cron.Core.Sections.DateSection.#ctor(Cron.Core.Enums.CronTimeSections)">
            <inheritdoc />
        </member>
        <member name="M:Cron.Core.Sections.DateSection.#ctor(Cron.Core.Enums.CronTimeSections,System.Boolean)">
            <summary>
            Initializes a new instance of the <see cref="T:Cron.Core.Sections.TimeSection" /> class.
            </summary>
            <param name="time">The time.</param>
            <param name="enabled">if set to <c>true</c> [enabled].</param>
        </member>
        <member name="T:Cron.Core.Sections.Section">
            <summary>
            Class Section.
            Implements the <see cref="T:Cron.Core.Interfaces.ISection" />
            </summary>
            <seealso cref="T:Cron.Core.Interfaces.ISection" />
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="M:Cron.Core.Sections.Section.IsTimeCronSection(Cron.Core.Enums.CronTimeSections)">
            <summary>
            Determines whether [is time cron section] [the specified time].
            </summary>
            <param name="time">The time.</param>
            <returns><c>true</c> if [is time cron section] [the specified time]; otherwise, <c>false</c>.</returns>
        </member>
        <member name="P:Cron.Core.Sections.Section.Item(System.Int32)">
            <summary>
            Gets the <see cref="T:Cron.Core.Interfaces.ISectionValues" /> at the specified index.
            </summary>
            <param name="index">The index.</param>
            <returns>ISectionValues.</returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="M:Cron.Core.Sections.Section.#ctor(Cron.Core.Enums.CronTimeSections,System.String)">
            <summary>
            Create an <see cref="T:Cron.Core.Interfaces.ISection" /> based on the specified expression.
            </summary>
            <param name="time">Specific <see cref="T:Cron.Core.Enums.CronTimeSections" />.</param>
            <param name="expression">Cron Expression</param>
            <remarks>Experimental.</remarks>
        </member>
        <member name="M:Cron.Core.Sections.Section.#ctor(Cron.Core.Enums.CronTimeSections)">
            <summary>
            Create <see cref="T:Cron.Core.Interfaces.ISection" /> for a specific <see cref="T:Cron.Core.Enums.CronTimeSections" />.
            </summary>
            <param name="time">The type of time section such as seconds, minutes, etc. See <see cref="T:Cron.Core.Enums.CronTimeSections" />.</param>
        </member>
        <member name="P:Cron.Core.Sections.Section.SectionType">
            <summary>
            Gets the type of the section.
            </summary>
            <value>The type of the section.</value>
        </member>
        <member name="P:Cron.Core.Sections.Section.Any">
            <summary>
            Indicates that the value should be translated using the ? any indicator.
            </summary>
            <value><c>true</c> if any; otherwise, <c>false</c>.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
            <remarks>Experimental.</remarks>
        </member>
        <member name="P:Cron.Core.Sections.Section.ContainsRange">
            <summary>
            Indicates if any values contain a range.
            </summary>
            <value><c>true</c> if [contains range]; otherwise, <c>false</c>.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISectionValues" />
        </member>
        <member name="P:Cron.Core.Sections.Section.Count">
            <summary>
            Gets the number of elements in the collection.
            </summary>
            <value>The count.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="P:Cron.Core.Sections.Section.Description">
            <inheritdoc />
        </member>
        <member name="P:Cron.Core.Sections.Section.Enabled">
            <summary>
            Indicates that the value is enabled or used. Equivalent to using ? in a cron expression.
            </summary>
            <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="P:Cron.Core.Sections.Section.Every">
            <summary>
            Indicates that the value should be translated using the */ every indicator.
            </summary>
            <value><c>true</c> if every; otherwise, <c>false</c>.</value>
            <exception cref="T:System.ArgumentOutOfRangeException"></exception>
            <exception cref="T:System.ArgumentOutOfRangeException"></exception>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="P:Cron.Core.Sections.Section.Values">
            <summary>
            List of Cron value expression specific to the <see cref="T:Cron.Core.Interfaces.ISection" />.
            </summary>
            <value>The values.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="P:Cron.Core.Sections.Section.Time">
            <summary>
            Gets or sets the time section Type <see cref="T:Cron.Core.Enums.CronTimeSections" />.
            </summary>
            <value>The time.</value>
        </member>
        <member name="M:Cron.Core.Sections.Section.Add(System.Int32)">
            <summary>
            Add time value to this <see cref="T:Cron.Core.Interfaces.ISection" />.
            </summary>
            <param name="value">Value for this <see cref="T:Cron.Core.Interfaces.ISection" />.</param>
            <returns>ISection.</returns>
            <exception cref="T:System.ArgumentOutOfRangeException"></exception>
            <exception cref="T:System.ArgumentOutOfRangeException"></exception>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="M:Cron.Core.Sections.Section.Add(System.Int32,System.Int32)">
            <summary>
            Add a time value range to this <see cref="T:Cron.Core.Interfaces.ISection" />.
            </summary>
            <param name="minVal">Starting value for this <see cref="T:Cron.Core.Interfaces.ISection" />.</param>
            <param name="maxVal">Ending value for this <see cref="T:Cron.Core.Interfaces.ISection" />.</param>
            <returns>ISection.</returns>
            <exception cref="T:System.ArgumentOutOfRangeException"></exception>
            <exception cref="T:System.ArgumentOutOfRangeException"></exception>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="M:Cron.Core.Sections.Section.Clear">
            <summary>
            Clear the values in the <see cref="T:Cron.Core.Interfaces.ISection" />.
            </summary>
            <returns>ISection.</returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="M:Cron.Core.Sections.Section.GetEnumerator">
            <summary>
            Returns an enumerator that iterates through the collection.
            </summary>
            <returns>An enumerator that can be used to iterate through the collection.</returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="M:Cron.Core.Sections.Section.System#Collections#IEnumerable#GetEnumerator">
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="M:Cron.Core.Sections.Section.IsInt">
            <summary>
            Indicates if this be represented as an integer.
            </summary>
            <returns><c>true</c> if this instance is int; otherwise, <c>false</c>.</returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISectionValues" />
        </member>
        <member name="M:Cron.Core.Sections.Section.IsValidRange(System.Int32)">
            <summary>
            Checks if the given value is valid for the current <see cref="T:Cron.Core.Interfaces.ISection" />'s <see cref="T:Cron.Core.Enums.CronTimeSections" /> value.
            </summary>
            <param name="value">Value for this <see cref="T:Cron.Core.Interfaces.ISection" />.</param>
            <returns><c>true</c> if [is valid range] [the specified value]; otherwise, <c>false</c>.</returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="M:Cron.Core.Sections.Section.Remove(System.Int32)">
            <summary>
            Remove the specified value from the <see cref="T:Cron.Core.Interfaces.ISection" />.
            </summary>
            <param name="value">Value for this <see cref="T:Cron.Core.Interfaces.ISection" />.</param>
            <returns>ISection.</returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="M:Cron.Core.Sections.Section.Remove(System.Int32,System.Int32)">
            <summary>
            Remove the specified range of values from the <see cref="T:Cron.Core.Interfaces.ISection" />.
            </summary>
            <param name="minVal">Starting value for this <see cref="T:Cron.Core.Interfaces.ISection" />.</param>
            <param name="maxVal">Ending value for this <see cref="T:Cron.Core.Interfaces.ISection" />.</param>
            <returns>ISection.</returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="M:Cron.Core.Sections.Section.ToInt">
            <summary>
            Convert to Integer.
            </summary>
            <returns>System.Int32.</returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISectionValues" />
        </member>
        <member name="M:Cron.Core.Sections.Section.ToString(System.Boolean,System.Type,System.Boolean)">
            <summary>
            Returns a <see cref="T:System.String" /> that represents this instance.
            </summary>
            <param name="translateEnum">Indicates if there is an enumerable, that it should be represented as a string instead of integer.</param>
            <param name="enumType">Type of Enumerable.</param>
            <param name="showEvery">Show every indicator.</param>
            <returns>A <see cref="T:System.String" /> that represents this instance.</returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="M:Cron.Core.Sections.Section.ToString">
            <summary>
            Returns a <see cref="T:System.String" /> that represents this instance.
            </summary>
            <returns>A <see cref="T:System.String" /> that represents this instance.</returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISection" />
        </member>
        <member name="T:Cron.Core.Sections.SectionValues">
            <summary>
            Class SectionValues.
            Implements the <see cref="T:Cron.Core.Interfaces.ISectionValues" />
            </summary>
            <seealso cref="T:Cron.Core.Interfaces.ISectionValues" />
            <inheritdoc cref="T:Cron.Core.Interfaces.ISectionValues" />
        </member>
        <member name="M:Cron.Core.Sections.SectionValues.#ctor(Cron.Core.Enums.CronTimeSections,System.Int32)">
            <summary>
            Initializes a new instance of the <see cref="T:Cron.Core.Sections.SectionValues" /> class.
            </summary>
            <param name="time">The time.</param>
            <param name="val">The value.</param>
        </member>
        <member name="M:Cron.Core.Sections.SectionValues.#ctor(Cron.Core.Enums.CronTimeSections,System.Int32,System.Int32)">
            <summary>
            Initializes a new instance of the <see cref="T:Cron.Core.Sections.SectionValues" /> class.
            </summary>
            <param name="time">The time.</param>
            <param name="minVal">The minimum value.</param>
            <param name="maxVal">The maximum value.</param>
        </member>
        <member name="P:Cron.Core.Sections.SectionValues.MaxValue">
            <summary>
            Maximum value in a value range.
            </summary>
            <value>The maximum value.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISectionValues" />
        </member>
        <member name="P:Cron.Core.Sections.SectionValues.MinValue">
            <summary>
            Minimum value in a value range. Also represents the only value, if the section is not a range.
            </summary>
            <value>The minimum value.</value>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISectionValues" />
        </member>
        <member name="M:Cron.Core.Sections.SectionValues.ToString(System.Boolean,System.Type)">
            <summary>
            Returns a <see cref="T:System.String" /> that represents this instance.
            </summary>
            <param name="translate">Translate values.</param>
            <param name="enumType">Associated Enum Type.</param>
            <returns>A <see cref="T:System.String" /> that represents this instance.</returns>
            <inheritdoc cref="T:Cron.Core.Interfaces.ISectionValues" />
        </member>
        <member name="M:Cron.Core.Sections.SectionValues.ToString">
            <inheritdoc />
        </member>
        <member name="T:Cron.Core.Sections.TimeSection">
            <summary>
            Class TimeSection.
            Implements the <see cref="T:Cron.Core.Sections.Section" />
            Implements the <see cref="T:Cron.Core.Interfaces.ITimeSection" />
            </summary>
            <seealso cref="T:Cron.Core.Sections.Section" />
            <seealso cref="T:Cron.Core.Interfaces.ITimeSection" />
            <inheritdoc cref="T:Cron.Core.Interfaces.ITimeSection" />
        </member>
        <member name="M:Cron.Core.Sections.TimeSection.#ctor(Cron.Core.Enums.CronTimeSections,System.String)">
            <inheritdoc />
        </member>
        <member name="M:Cron.Core.Sections.TimeSection.#ctor(Cron.Core.Enums.CronTimeSections)">
            <inheritdoc />
        </member>
        <member name="M:Cron.Core.Sections.TimeSection.#ctor(Cron.Core.Enums.CronTimeSections,System.Boolean)">
            <summary>
            Initializes a new instance of the <see cref="T:Cron.Core.Sections.TimeSection" /> class.
            </summary>
            <param name="time">The time.</param>
            <param name="enabled">if set to <c>true</c> [enabled].</param>
        </member>
        <member name="M:Cron.Core.Sections.TimeSection.IsValidRange(System.Int32)">
            <inheritdoc />
        </member>
        <member name="P:Cron.Core.Sections.TimeSection.AllowedIncrements">
            <inheritdoc />
        </member>
    </members>
</doc>
